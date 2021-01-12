using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using NoteApp;
using System.Reflection;
using System.IO;

namespace NoteAppUI
{
    public partial class MainForm : Form
    {
        /// <summary>
        /// Переменная для хранения всех заметок проекта.
        /// </summary>
        private Project _project;
        /// <summary>
        /// Переменная для хранения всех названий заметок проекта.
        /// </summary>
        private List<Note> _actualListBox = new List<Note>();
        /// <summary>
        /// Переменная для хранения отсортированных названий заметок проекта.
        /// </summary>
        private List<Note> _sortListBox = new List<Note>();

        /// <summary>
        /// Иницилизация объектов формы.
        /// Отображение 
        /// </summary>
        public MainForm()
        {
            InitializeComponent();
            
            _project = ProjectManager.LoadFromFile(_folderPath);
            
            foreach (int i in Enum.GetValues(typeof(NoteCategory)))
                CategoryComboBox.Items.Add(GetDescription((NoteCategory)Enum.GetValues(typeof(NoteCategory)).GetValue(i)));
            CategoryComboBox.SelectedIndex = 0;
            UpdateListBox();

            if (_project.SelectedIndex > 0)
                noteListBox.SelectedIndex = _project.SelectedIndex;
            else
            {
                if (_project.Notes.Count > 0)
                    noteListBox.SelectedIndex = 0;
            }
        }

        /// <summary>
        /// Элементы enum в переводе на русский.
        /// </summary>
        /// <param name="enumElement">Элемент перечисления</param>
        /// <returns>Название элемента</returns>
        static string GetDescription(Enum enumElement)
        {
            Type type = enumElement.GetType();

            MemberInfo[] memInfo = type.GetMember(enumElement.ToString());
            if (memInfo != null && memInfo.Length > 0)
            {
                object[] attrs = memInfo[0].GetCustomAttributes(typeof(DescriptionAttribute), false);
                if (attrs != null && attrs.Length > 0)
                    return ((DescriptionAttribute)attrs[0]).Description;
            }
            return enumElement.ToString();
        }

        /// <summary>
        /// Путь к папке с файлом заметок.
        /// </summary>
        private readonly string _filePath = ProjectManager.SaveFile;
        private readonly string _folderPath = ProjectManager.FolderPath;
        /// <summary>
        /// Функция добавление новой заметки в коллекцию.
        /// </summary>
        private void AddNote()
        {
            var note = new NoteForm();

            if (note.ShowDialog() == DialogResult.OK)
            {
                _project.Notes.Add(note._Note);
                noteListBox.Items.Add(note._Note.Title);
                ProjectManager.SaveToFile(_project, _filePath, _folderPath);

                _actualListBox.Add(note._Note);
                CategoryComboBox.SelectedIndex = 0;
                UpdateListBox();
                noteListBox.SelectedIndex = 0;
            }
        }

        /// <summary>
        /// Функция для редактирование заметки
        /// </summary>
        private void EditNote()
        {
            if (noteListBox.SelectedIndex == -1)
            {
                toolTip.Show("Не выбрана заметка для редактирования", noteListBox, 200, 10);
            }
            else
            {
                toolTip.Hide(noteListBox);
                var selectIndex = noteListBox.SelectedIndex;
                var selectNote = _actualListBox[selectIndex];

                var updateNote = new NoteForm { _Note = selectNote };
                var dialogResult = updateNote.ShowDialog();
                if (dialogResult == DialogResult.OK)
                {
                    var projectEditIndex = _project.Notes.IndexOf(selectNote);
                    _project.Notes.RemoveAt(projectEditIndex);
                    _project.Notes.Insert(projectEditIndex, updateNote._Note);
                    CategoryComboBox.SelectedIndex = 0;
                    UpdateListBox();
                    noteListBox.SelectedIndex = 0;
                }
                ProjectManager.SaveToFile(_project, _filePath, _folderPath);
            }
        }

        /// <summary>
        /// Функция для удаления заметки
        /// </summary>
        private void DeleteNote()
        {
            if (noteListBox.SelectedIndex == -1)
            {
                toolTip.Show("Не выбрана заметка для удаления", noteListBox, 200, 10);
            }
            else
            {
                toolTip.Hide(noteListBox);
                var selectIndex = noteListBox.SelectedIndex;
                var selectNote = _actualListBox[selectIndex];
                var result = MessageBox.Show("Заметка будет безвозвратно удалена. Продолжить?", "Удаление заметки", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    var projectEditIndex = _project.Notes.IndexOf(selectNote);
                    _project.Notes.RemoveAt(projectEditIndex);
                    CategoryComboBox.SelectedIndex = 0;
                    UpdateListBox();
                }
                ProjectManager.SaveToFile(_project, _filePath, _folderPath);
                if (noteListBox.Items.Count > 0)
                {
                    noteListBox.SelectedIndex = 0;
                }
                else
                {
                    ListBoxNotEmpty();
                }
            }
        }
        
        /// <summary>
        ///При закрытии формы данные сохраняются в файл 
        /// </summary>
        private void MainForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            LastSelectedNote();
            ProjectManager.SaveToFile(_project, _filePath, _folderPath);
        }

        /// <summary>
        /// Функция, для отображения заметок на форме
        /// когда пользователь выбрал заметку в листе
        /// </summary>
        private void noteListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (noteListBox.SelectedIndex >= 0)
            {
                var selectedNote = _actualListBox[noteListBox.SelectedIndex];

                noteLabel.Text = selectedNote.Title;
                contentBox.Text = selectedNote.Content;
                dateTimeCreate.Value = selectedNote.CreatedTime;
                dateTimeUpdate.Value = selectedNote.UpdateTime;
                categoryLabel.Text = GetDescription(selectedNote.Category);
                LastSelectedNote();
            }
            else
            {
                ListBoxNotEmpty();
            }
        }

        //Отображение данных на правой панели по умолчанию.
        private void ListBoxNotEmpty()
        {
            noteLabel.Text = "Заголовок";
            contentBox.Text = "";
            dateTimeCreate.Value = DateTime.Now;
            dateTimeUpdate.Value = DateTime.Now;
            categoryLabel.Text = "Категория";
        }

        /// <summary>
        /// Функция для обновление ListBox при выборе категории.
        /// </summary>
        private void UpdateListBox()
        {
            //Все отсортированные заметки проекта
            _sortListBox = _project.SortNotes(_project.Notes);

            if (CategoryComboBox.SelectedIndex == 0)
            {
                noteListBox.Items.Clear();
                _actualListBox.Clear();
                for (int i = 0; i < _sortListBox.Count; i++)
                {
                    _actualListBox.Add(_sortListBox[i]);
                    noteListBox.Items.Add(_sortListBox[i].Title);
                }
            }
            else
            {
                noteListBox.Items.Clear();
                _actualListBox.Clear();
                for (int i = 0; i < _sortListBox.Count; i++)
                {
                    if (CategoryComboBox.SelectedItem.ToString() == GetDescription(_sortListBox[i].Category))
                    {
                        _actualListBox.Add(_sortListBox[i]);
                        noteListBox.Items.Add(_sortListBox[i].Title);
                    }
                }
            }
        }

        /// <summary>
        /// Фиксирование выбранной заметки относительно текущей выбранной категории.
        /// </summary>
        private void LastSelectedNote()
        {
            _sortListBox = _project.SortNotes(_project.Notes);

            if (noteListBox.SelectedIndex >= 0)
            {
                _project.SelectedIndex = _sortListBox.IndexOf(_actualListBox[noteListBox.SelectedIndex]);
            }
            else
            {
                _project.SelectedIndex = -1;
            }
        }

        //Функция изменения категории
        private void CategoryComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateListBox();
        }

        private void aboutProgramToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AboutForm form = new AboutForm();
            form.Show();
        }

        //добавление/редактироование/удаление при нажатии кнопок или элемента в меню
        private void changeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EditNote();
        }

        private void closeAppToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        
        private void pictureCreateBox_Click(object sender, EventArgs e)
        {
            AddNote();
        }

        private void pictureEditBox_Click(object sender, EventArgs e)
        {
            EditNote();
        }

        private void pictureDeleteBox_Click(object sender, EventArgs e)
        {
            DeleteNote();
        }
        
        //анимация кнопок
        private void pictureCreateBox_MouseEnter(object sender, EventArgs e)
        {
            pictureCreateBox.Image = Properties.Resources.create_focus;
        }

        private void pictureCreateBox_MouseLeave(object sender, EventArgs e)
        {
            pictureCreateBox.Image = Properties.Resources.create_unfocus;
        }

        private void pictureEditBox_MouseEnter(object sender, EventArgs e)
        {
            pictureEditBox.Image = Properties.Resources.edit_focus;
        }

        private void pictureEditBox_MouseLeave(object sender, EventArgs e)
        {
            pictureEditBox.Image = Properties.Resources.edit_unfocus;
        }

        private void pictureDeleteBox_MouseEnter(object sender, EventArgs e)
        {
            pictureDeleteBox.Image = Properties.Resources.delete_focus;
        }

        private void pictureDeleteBox_MouseLeave(object sender, EventArgs e)
        {
            pictureDeleteBox.Image = Properties.Resources.delete_unfocus;
        }
    }
}
