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
    /// <summary>
    /// Класс взаимодействия MainForm.
    /// </summary>
    public partial class NoteForm : Form
    {
        //Для *
        string startTitle = "";
        string startNote = "";
        string startCategory = "Работа";
        bool _isChangeTitle;
        bool _isChangeText;
        bool _isChangeCategory;

        private Note _note = new Note();
        /// <summary>
        /// Переменная для временного хранения данных заметок.
        /// </summary>
        public Note _Note
        {
            get
            {
                return _note;
            }
            set
            {
                _note = (Note)value.Clone();
                
                titleBox.Text = value.Title;
                dateTimeCreate.Value = value.CreatedTime;
                dateTimeUpdate.Value = value.UpdateTime;
                noteBox.Text = value.Content;
                CategoryComboBox.Text = GetDescription((value.Category));
                
                startTitle = titleBox.Text;
                startNote = noteBox.Text;
                startCategory = CategoryComboBox.Text;
            }
        }
        
        public NoteForm()
        {
            InitializeComponent();

            foreach (int i in Enum.GetValues(typeof(NoteCategory)))
                CategoryComboBox.Items.Add(GetDescription((NoteCategory)Enum.GetValues(typeof(NoteCategory)).GetValue(i)));

            CategoryComboBox.SelectedIndex = 0;
        }

        private void NoteForm_Load(object sender, EventArgs e)
        {
            this.Text = "Создать или изменить заметку";
            _isChangeTitle = false;
            _isChangeText = false;
            _isChangeCategory = false;
        }


        private void backButton_Click(object sender, EventArgs e)
        {
            if (_isChangeTitle||_isChangeText || _isChangeCategory)
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
            {
                _isChangeTitle = true;
                titleChande();
            }
            else
            {
                _isChangeTitle = false;
                titleChande();
            }
            
            if (titleBox.Text.Length < 50)
            {
                titleBox.BackColor = Color.White;
                labelNoteTitle.Text = titleBox.Text;

                toolTip1.Hide(titleBox);

                if (titleBox.Text.Length == 0)
                    labelNoteTitle.Text = "ЗАМЕТКА";
            }
            else
            {
                titleBox.BackColor = Color.Tomato;
                toolTip1.Show("Превышено допустимое количество символов", titleBox, 305, 10);
            }
        }

        private void noteBox_TextChanged(object sender, EventArgs e)
        {
            if (startNote != noteBox.Text)
            {
                _isChangeText = true;
                titleChande();
            }
            else
            {
                _isChangeText = false;
                titleChande();
            }
        }


        private void CategoryComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (startCategory != CategoryComboBox.Text)
            {
                _isChangeCategory = true;
                titleChande();
            }
            else
            {
                _isChangeCategory = false;
                titleChande();
            }
        }

        private void titleChande()
        {
            if (_isChangeTitle || _isChangeText || _isChangeCategory)
                this.Text = "*Создать или изменить заметку";
            else
                this.Text = "Создать или изменить заметку";
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            //сохранение заметки
            UpdateNote();

            titleBox.Clear();
            noteBox.Clear();
            CategoryComboBox.SelectedIndex = 0;
            _isChangeTitle = false;
            _isChangeText = false;
            titleChande();
        }

        /// <summary>
        /// Создается новая заметка для
        /// -редактирования, либо
        /// -сохранения
        /// </summary>
        private void UpdateNote()
        {
            try
            {
                _Note.Title = titleBox.Text;
                _Note.CreatedTime = dateTimeCreate.Value;
                _Note.UpdateTime = DateTime.Now;
;
                _Note.Content = noteBox.Text;
                
                NoteCategory selectedNoteCategory;
                selectedNoteCategory = (NoteCategory)CategoryComboBox.SelectedIndex;
                _Note.Category = selectedNoteCategory;

                DialogResult = DialogResult.OK;
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, @"Error",MessageBoxButtons.OK, MessageBoxIcon.Error);
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
    }
}