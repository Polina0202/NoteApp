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
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            foreach (int i in Enum.GetValues(typeof(NoteCategory)))
                 CategoryBox1.Items.Add(Enum.GetName(typeof(NoteCategory), i));
            CategoryBox1.SelectedIndex = 0;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Создаем заметка
            Note Note = new Note();

            //Записываем информацию с формы
            Note.Title = textBox1.Text;
            Note.Content = textBox2.Text;
            NoteCategory selectedNoteCategory;
            selectedNoteCategory = (NoteCategory)CategoryBox1.SelectedIndex;
            Note.Category = selectedNoteCategory;
            Note.ChangeTime = DateTime.Now;

            //Сериализация
            Project serelProject = new Project { Notes = { Note } };
            ProjectManager.SaveToFile(serelProject, ProjectManager.savefile);

            //Десериализация
            Project deserProject = ProjectManager.LoadFromFile(ProjectManager.savefile);

            MessageBox.Show("Заметка сохранена");
        }
    }
}
