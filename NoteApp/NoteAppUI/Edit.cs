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
    /// <summary>
    /// Класс взаимодействия MainForm.
    /// </summary>
    public partial class Edit : Form
    {
        string startTitle = "";
        string startNote = "";

        private Note _storage = new Note();
        /// <summary>
        /// Переменная для временного хранения данных заметок.
        /// </summary>
        public Note Storage
        {
            get
            {
                return _storage;
            }
            set
            {
                _storage = (Note)value.Clone();


                titleBox.Text = value.Title;
                dateTimeCreate.Value = value.CreationTime;
                dateTimeUpdate.Value = value.UpdateTime;
                noteBox.Text = value.Content;
                CategoryBox.Text = value.Category.ToString();
            }
        }
        
        public Edit()
        {
            InitializeComponent();
            dateTimeCreate.CustomFormat = "HH:mm  dd.MMM.2kyy";
            dateTimeUpdate.CustomFormat = "HH:mm  dd.MMM.2kyy";

            foreach (int i in Enum.GetValues(typeof(NoteCategory)))
                CategoryBox.Items.Add(Enum.GetName(typeof(NoteCategory), i));
            CategoryBox.SelectedIndex = 0;

            CategoryBox.DropDownStyle = ComboBoxStyle.DropDownList;
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            startTitle = titleBox.Text;
            startNote = noteBox.Text;
            this.Text = "Создать или изменить заметку";

        }

        private void backButton_Click(object sender, EventArgs e)
        {
            if (this.Text == "*Создать или изменить заметку")
            {
                MessageBoxButtons buttons = MessageBoxButtons.OKCancel;
                DialogResult result;
                result = MessageBox.Show(this, "Вы действительно хотите выйти?", "Заметка не сохранена", buttons, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign);
                if (result == DialogResult.OK)
                {
                    this.Close();
                }
            }
            else
            {
                this.Close();
            }
        }

        private void titleBox_TextChanged(object sender, EventArgs e)
        {
            if (startTitle != titleBox.Text)
                this.Text = "*Создать или изменить заметку";
            else
                this.Text = "Создать или изменить заметку";

            if (titleBox.Text.Length < 50)
            {
                titleBox.BackColor = Color.White;
                labelTitleError.Visible = false;
            }
            else
            {
                titleBox.BackColor = Color.Tomato;
                labelTitleError.Visible = true;
                labelTitleError.Text = "Превышено допустимое количество символов";
                labelTitleError.BackColor = Color.Tomato;
            }
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            //сохранение заметки
            AddEditNote();

            titleBox.Clear();
            noteBox.Clear();
            CategoryBox.SelectedIndex = 0;
            this.Text = "Создать или изменить заметку";

            MessageBox.Show("Заметка сохранена");
        }

        /// <summary>
        /// Создается новая заметка для
        /// -редактирования, либо
        /// -сохранения
        /// </summary>
        private void AddEditNote()
        {
            try
            {
                Storage.Title = titleBox.Text;
                Storage.CreationTime = dateTimeCreate.Value;
                Storage.UpdateTime = DateTime.Now;
;
                Storage.Content = noteBox.Text;

                NoteCategory selectedNoteCategory;
                selectedNoteCategory = (NoteCategory)CategoryBox.SelectedIndex;
                Storage.Category = selectedNoteCategory;

                DialogResult = DialogResult.OK;
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, @"Error",MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void noteBox_TextChanged(object sender, EventArgs e)
        {
            if (startNote != noteBox.Text)
                this.Text = "*Создать или изменить заметку";
            else
                this.Text = "Создать или изменить заметку";
        }
    }
}