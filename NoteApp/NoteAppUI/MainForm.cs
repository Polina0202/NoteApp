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

            dateTimeCreate.CustomFormat = "HH:mm  dd.MMM.2kyy";
            dateTimeUpdate.CustomFormat = "HH:mm  dd.MMM.2kyy";
            this.Text = "Коллекция ваших заметок";

            pictureCreateBox.Cursor = Cursors.Hand;
            pictureEditBox.Cursor = Cursors.Hand;
            pictureDeleteBox.Cursor = Cursors.Hand;

            foreach (int i in Enum.GetValues(typeof(NoteCategory)))
                CategoryBox1.Items.Add(Enum.GetName(typeof(NoteCategory), i));
            CategoryBox1.SelectedIndex = 0;

            CategoryBox1.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        /// <summary>
        /// Путь к папке с файлом заметок.
        /// </summary>
        private readonly string _filePath = ProjectManager.Savefile;

        /// <summary>
        /// Функция добавление новой заметки в коллекцию.
        /// </summary>
        private void NoteAdd()
        {
            var note = new EditForm();

            if (note.ShowDialog() != DialogResult.OK)
            {
                return;
            }
            _project.Notes.Add(note.Storage);
            listNoteBox.Items.Add(note.Storage.Title);
            ProjectManager.SaveToFile(_project, _filePath);
        }
        /// <summary>
        /// Функция для редактирование заметки
        /// </summary>
        private void NoteEdit()
        {
            if (listNoteBox.SelectedIndex == -1)
            {
                errorLabel.Text = "Не выбрана заметка для редактирования";
                errorLabel.BackColor = Color.Tomato;
            }
            else
            {
                errorLabel.Visible = false;
                var selectIndex = listNoteBox.SelectedIndex;
                var selectNote = _project.Notes[selectIndex];

                var updateNote = new EditForm { Storage = selectNote };
                var dialogResult = updateNote.ShowDialog();
                if (dialogResult != DialogResult.OK)
                {
                    return;
                }
                _project.Notes.RemoveAt(selectIndex);
                listNoteBox.Items.RemoveAt(selectIndex);
                _project.Notes.Insert(selectIndex, updateNote.Storage);
                listNoteBox.Items.Insert(selectIndex, updateNote.Storage.Title);
                listNoteBox.SelectedIndex = selectIndex;
                ProjectManager.SaveToFile(_project, _filePath);
            }
        }

        /// <summary>
        /// Функция для удаления заметки
        /// </summary>
        private void NoteDelete()
        {
            if (listNoteBox.SelectedIndex == -1)
            {
                errorLabel.Text = "Не выбрана заметка для удаления";
                errorLabel.BackColor = Color.Tomato;
            }
            else
            {
                errorLabel.Visible = false;
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

        private void MainForm_Load(object sender, EventArgs e)
        {
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
                categoryLabel.Text = _project.Notes[i].Category.ToString();
            }

        }

        private void оПрограммеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AboutForm form = new AboutForm();
            form.Show();
        }

        //добавление/редактироование/удаление при нажатии кнопок или жлемента в меню
        private void изменитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NoteEdit();
        }

        private void закрытьПриложениеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        
        private void pictureCreateBox_Click(object sender, EventArgs e)
        {
            NoteAdd();
        }

        private void pictureEditBox_Click(object sender, EventArgs e)
        {
            NoteEdit();
        }

        private void pictureDeleteBox_Click(object sender, EventArgs e)
        {
            NoteDelete();
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
