using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using NoteApp;
using System.Reflection;

namespace NoteAppUI
{
    public partial class MainForm : Form
    {
        /// <summary>
        /// Переменная для хранения всех заметок проекта.
        /// </summary>
        private Project _project;

        /// <summary>
        /// Иницилизация объектов формы
        /// </summary>
        public MainForm()
        {
            InitializeComponent();

            _project = ProjectManager.LoadFromFile(_filePath);
            foreach (var i in _project.Notes)
                listNoteBox.Items.Add(i.Title);

            foreach (int i in Enum.GetValues(typeof(NoteCategory)))
                CategoryComboBox.Items.Add(GetDescription((NoteCategory)Enum.GetValues(typeof(NoteCategory)).GetValue(i)));
            
            CategoryComboBox.SelectedIndex = 0;
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
        private readonly string _filePath = ProjectManager.Savefile;

        /// <summary>
        /// Функция добавление новой заметки в коллекцию.
        /// </summary>
        private void AddNote()
        {
            var note = new NoteForm();

            if (note.ShowDialog() != DialogResult.OK)
            {
                return;
            }
            _project.Notes.Add(note._Note);
            listNoteBox.Items.Add(note._Note.Title);
            ProjectManager.SaveToFile(_project, _filePath);

            listNoteBox.SelectedIndex = listNoteBox.Items.Count - 1;
        }
        /// <summary>
        /// Функция для редактирование заметки
        /// </summary>
        private void EditNote()
        {
            if (listNoteBox.SelectedIndex == -1)
            {
                toolTip1.Show("Не выбрана заметка для редактирования", listNoteBox, 200, 10);
            }
            else
            {
                toolTip1.Hide(listNoteBox);
                var selectIndex = listNoteBox.SelectedIndex;
                var selectNote = _project.Notes[selectIndex];

                var updateNote = new NoteForm { _Note = selectNote };
                var dialogResult = updateNote.ShowDialog();
                if (dialogResult != DialogResult.OK)
                {
                    return;
                }
                _project.Notes.RemoveAt(selectIndex);
                listNoteBox.Items.RemoveAt(selectIndex);
                _project.Notes.Insert(selectIndex, updateNote._Note);
                listNoteBox.Items.Insert(selectIndex, updateNote._Note.Title);
                listNoteBox.SelectedIndex = selectIndex;
                ProjectManager.SaveToFile(_project, _filePath);
            }
        }

        /// <summary>
        /// Функция для удаления заметки
        /// </summary>
        private void DeleteNote()
        {
            if (listNoteBox.SelectedIndex == -1)
            {
                toolTip1.Show("Не выбрана заметка для удаления", listNoteBox, 200, 10);
            }
            else
            {
                toolTip1.Hide(listNoteBox);
                var selectedIndex = listNoteBox.SelectedIndex;
                var result = MessageBox.Show("Заметка будет безвозвратно удалена. Продолжить?", "Удаление заметки", MessageBoxButtons.YesNo);
                if (result != DialogResult.Yes)
                {
                    return;
                }
                _project.Notes.RemoveAt(selectedIndex);
                listNoteBox.Items.RemoveAt(selectedIndex);
                ProjectManager.SaveToFile(_project, _filePath);
                if (listNoteBox.Items.Count > 0)
                {
                    listNoteBox.SelectedIndex = 0;
                }
            }
        }
        
        /// <summary>
        ///При закрытии формы данные сохраняются в файл 
        /// </summary>
        private void MainForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            ProjectManager.SaveToFile(_project, _filePath);
        }

        /// <summary>
        /// Функция, для отображения заметок на форме
        /// когда пользователь выбрал заметку в листе
        /// </summary>
        private void listNoteBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listNoteBox.SelectedIndex >= 0)
            {
                var i = listNoteBox.SelectedIndex;
                noteLabel.Text = _project.Notes[i].Title;
                contentBox.Text = _project.Notes[i].Content;
                dateTimeCreate.Value = _project.Notes[i].CreationTime;
                dateTimeUpdate.Value = _project.Notes[i].UpdateTime;
                categoryLabel.Text = GetDescription(_project.Notes[i].Category);
            }
        }

        private void aboutProgramToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AboutForm form = new AboutForm();
            form.Show();
        }

        //добавление/редактироование/удаление при нажатии кнопок или жлемента в меню
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
