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
using System.Windows;

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
        
        //Иницилизация формы.
        public NoteForm()
        {
            InitializeComponent();

            foreach (int i in Enum.GetValues(typeof(NoteCategory)))
            {
                if (i > 0 )
                    CategoryComboBox.Items.Add(GetDescription((NoteCategory)Enum.GetValues(typeof(NoteCategory)).GetValue(i)));
            }

            CategoryComboBox.SelectedIndex = 0;
        }

        //Установка значений призагрузке формы.
        private void NoteForm_Load(object sender, EventArgs e)
        {
            this.Text = "Создать или изменить заметку";
            _isChangeTitle = false;
            _isChangeText = false;
            _isChangeCategory = false;
        }

        //
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

                toolTip.Hide(titleBox);

                if (titleBox.Text.Length == 0)
                    labelNoteTitle.Text = "ЗАМЕТКА";
            }
            else
            {
                titleBox.BackColor = Color.Tomato;
                toolTip.Show("Превышено допустимое количество символов", titleBox, 305, 10);
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
                _Note.Category = selectedNoteCategory+1;

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

        //Открытия листа с emoji.
        private void emojiButton_Click(object sender, EventArgs e)
        {
            if (emojiListView.Visible == true)
                emojiListView.Visible = false;
            else
                emojiListView.Visible = true;
        }

        //Действия при выборе emoji.
        private void emojiListView_SelectedIndexChanged(object sender, EventArgs e)
        {
            for (int i = 0; i < emojiListView.Items.Count; i++)
            {
                if (emojiListView.Items[i].Selected == true)
                    printEmoji(i);
            }
        }

        /// <summary>
        /// Функция для добавления emoji в текст TextBox относительно текущего расположения каретки.
        /// </summary>
        private void printEmoji(int selectedChar)
        {
            string stringBeforeCaret = "";
            string stringAfterCaret = "";
            int caretIndex = noteBox.SelectionStart;

            if ((emojiListView.Items[selectedChar].Selected == true))
            {
                stringBeforeCaret = noteBox.Text.Substring(0, noteBox.SelectionStart);
                if ((noteBox.Text.Length > 0) && (noteBox.SelectionStart != noteBox.Text.Length))
                {
                    stringAfterCaret = noteBox.Text.Substring(noteBox.SelectionStart, noteBox.Text.Length - noteBox.SelectionStart);
                }
                stringBeforeCaret += emojiListView.Items[selectedChar].Text;
                stringBeforeCaret += stringAfterCaret;
                noteBox.Text = stringBeforeCaret;
                noteBox.SelectionStart = caretIndex + 1;
                noteBox.Focus();
            }
        }

        //анимация кнопки
        private void emojiButton_MouseEnter(object sender, EventArgs e)
        {
            emojiButton.Image = Properties.Resources.emoji_focus;
        }

        private void emojiButton_MouseLeave(object sender, EventArgs e)
        {
            emojiButton.Image = Properties.Resources.emoji_unfocus;
        }
    }
}