using System;
using System.Windows.Forms;

namespace NoteAppUI
{
    public partial class About : Form
    {
        public About()
        {
            InitializeComponent();
            this.Text = "О программе";
            emailLabel.Cursor = Cursors.Hand;
        }

        private void label7_Click(object sender, EventArgs e)
        {
     
            Clipboard.SetDataObject(emailLabel.Text);
        }

        private void About_Load(object sender, EventArgs e)
        {

        }

        private void githubLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://github.com/Polina0202/NoteApp.git");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
