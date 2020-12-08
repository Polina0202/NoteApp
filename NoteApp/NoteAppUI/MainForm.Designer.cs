namespace NoteAppUI
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.файлToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.закрытьПриложениеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.изменитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.помощьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.оПрограммеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1 = new System.Windows.Forms.Panel();
            this.errorLabel = new System.Windows.Forms.Label();
            this.listNoteBox = new System.Windows.Forms.ListBox();
            this.CategoryBox1 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dateTimeUpdate = new System.Windows.Forms.DateTimePicker();
            this.contentBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.dateTimeCreate = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.categoryLabel = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.noteLabel = new System.Windows.Forms.Label();
            this.pictureEditBox = new System.Windows.Forms.PictureBox();
            this.pictureDeleteBox = new System.Windows.Forms.PictureBox();
            this.pictureCreateBox = new System.Windows.Forms.PictureBox();
            this.menuStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEditBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureDeleteBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureCreateBox)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.файлToolStripMenuItem,
            this.изменитьToolStripMenuItem,
            this.помощьToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1214, 28);
            this.menuStrip1.TabIndex = 13;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // файлToolStripMenuItem
            // 
            this.файлToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.закрытьПриложениеToolStripMenuItem});
            this.файлToolStripMenuItem.Name = "файлToolStripMenuItem";
            this.файлToolStripMenuItem.Size = new System.Drawing.Size(57, 24);
            this.файлToolStripMenuItem.Text = "Файл";
            // 
            // закрытьПриложениеToolStripMenuItem
            // 
            this.закрытьПриложениеToolStripMenuItem.Name = "закрытьПриложениеToolStripMenuItem";
            this.закрытьПриложениеToolStripMenuItem.Size = new System.Drawing.Size(234, 26);
            this.закрытьПриложениеToolStripMenuItem.Text = "Закрыть приложение";
            this.закрытьПриложениеToolStripMenuItem.Click += new System.EventHandler(this.закрытьПриложениеToolStripMenuItem_Click);
            // 
            // изменитьToolStripMenuItem
            // 
            this.изменитьToolStripMenuItem.Name = "изменитьToolStripMenuItem";
            this.изменитьToolStripMenuItem.Size = new System.Drawing.Size(90, 24);
            this.изменитьToolStripMenuItem.Text = "Изменить";
            this.изменитьToolStripMenuItem.Click += new System.EventHandler(this.изменитьToolStripMenuItem_Click);
            // 
            // помощьToolStripMenuItem
            // 
            this.помощьToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.оПрограммеToolStripMenuItem});
            this.помощьToolStripMenuItem.Name = "помощьToolStripMenuItem";
            this.помощьToolStripMenuItem.Size = new System.Drawing.Size(81, 24);
            this.помощьToolStripMenuItem.Text = "Помощь";
            // 
            // оПрограммеToolStripMenuItem
            // 
            this.оПрограммеToolStripMenuItem.Name = "оПрограммеToolStripMenuItem";
            this.оПрограммеToolStripMenuItem.Size = new System.Drawing.Size(179, 26);
            this.оПрограммеToolStripMenuItem.Text = "О программе";
            this.оПрограммеToolStripMenuItem.Click += new System.EventHandler(this.оПрограммеToolStripMenuItem_Click);
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.panel1.Controls.Add(this.errorLabel);
            this.panel1.Controls.Add(this.listNoteBox);
            this.panel1.Controls.Add(this.CategoryBox1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(12, 32);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(461, 561);
            this.panel1.TabIndex = 14;
            // 
            // errorLabel
            // 
            this.errorLabel.AutoSize = true;
            this.errorLabel.BackColor = System.Drawing.SystemColors.Control;
            this.errorLabel.Location = new System.Drawing.Point(6, 45);
            this.errorLabel.Name = "errorLabel";
            this.errorLabel.Size = new System.Drawing.Size(0, 17);
            this.errorLabel.TabIndex = 3;
            // 
            // listNoteBox
            // 
            this.listNoteBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.listNoteBox.FormattingEnabled = true;
            this.listNoteBox.ItemHeight = 16;
            this.listNoteBox.Location = new System.Drawing.Point(6, 65);
            this.listNoteBox.Name = "listNoteBox";
            this.listNoteBox.ScrollAlwaysVisible = true;
            this.listNoteBox.Size = new System.Drawing.Size(439, 484);
            this.listNoteBox.TabIndex = 2;
            this.listNoteBox.SelectedIndexChanged += new System.EventHandler(this.listNoteBox_SelectedIndexChanged);
            // 
            // CategoryBox1
            // 
            this.CategoryBox1.FormattingEnabled = true;
            this.CategoryBox1.Location = new System.Drawing.Point(218, 16);
            this.CategoryBox1.Name = "CategoryBox1";
            this.CategoryBox1.Size = new System.Drawing.Size(227, 24);
            this.CategoryBox1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(209, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Выберите категорию заметок:";
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.Controls.Add(this.dateTimeUpdate);
            this.panel2.Controls.Add(this.contentBox);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.dateTimeCreate);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.categoryLabel);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.noteLabel);
            this.panel2.Location = new System.Drawing.Point(479, 31);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(735, 622);
            this.panel2.TabIndex = 15;
            // 
            // dateTimeUpdate
            // 
            this.dateTimeUpdate.Enabled = false;
            this.dateTimeUpdate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimeUpdate.Location = new System.Drawing.Point(541, 92);
            this.dateTimeUpdate.Name = "dateTimeUpdate";
            this.dateTimeUpdate.Size = new System.Drawing.Size(185, 22);
            this.dateTimeUpdate.TabIndex = 7;
            this.dateTimeUpdate.Value = new System.DateTime(2020, 1, 1, 0, 0, 0, 0);
            // 
            // contentBox
            // 
            this.contentBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.contentBox.Location = new System.Drawing.Point(21, 120);
            this.contentBox.Multiline = true;
            this.contentBox.Name = "contentBox";
            this.contentBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.contentBox.Size = new System.Drawing.Size(705, 475);
            this.contentBox.TabIndex = 0;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(325, 92);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(210, 17);
            this.label4.TabIndex = 6;
            this.label4.Text = "Время последнего изменения:";
            // 
            // dateTimeCreate
            // 
            this.dateTimeCreate.Enabled = false;
            this.dateTimeCreate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimeCreate.Location = new System.Drawing.Point(138, 92);
            this.dateTimeCreate.Name = "dateTimeCreate";
            this.dateTimeCreate.Size = new System.Drawing.Size(185, 22);
            this.dateTimeCreate.TabIndex = 4;
            this.dateTimeCreate.Value = new System.DateTime(2020, 1, 1, 0, 0, 0, 0);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 92);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(120, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Время создания:";
            // 
            // categoryLabel
            // 
            this.categoryLabel.AutoSize = true;
            this.categoryLabel.Location = new System.Drawing.Point(96, 52);
            this.categoryLabel.Name = "categoryLabel";
            this.categoryLabel.Size = new System.Drawing.Size(77, 17);
            this.categoryLabel.TabIndex = 2;
            this.categoryLabel.Text = "Категория";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(18, 52);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 17);
            this.label3.TabIndex = 1;
            this.label3.Text = "Категория:";
            // 
            // noteLabel
            // 
            this.noteLabel.AutoSize = true;
            this.noteLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.noteLabel.Location = new System.Drawing.Point(15, 7);
            this.noteLabel.Name = "noteLabel";
            this.noteLabel.Size = new System.Drawing.Size(162, 32);
            this.noteLabel.TabIndex = 0;
            this.noteLabel.Text = "Заголовок";
            // 
            // pictureEditBox
            // 
            this.pictureEditBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.pictureEditBox.Image = global::NoteAppUI.Properties.Resources.edit_unfocus;
            this.pictureEditBox.Location = new System.Drawing.Point(65, 603);
            this.pictureEditBox.Name = "pictureEditBox";
            this.pictureEditBox.Size = new System.Drawing.Size(44, 40);
            this.pictureEditBox.TabIndex = 8;
            this.pictureEditBox.TabStop = false;
            this.pictureEditBox.Click += new System.EventHandler(this.pictureEditBox_Click);
            this.pictureEditBox.MouseEnter += new System.EventHandler(this.pictureEditBox_MouseEnter);
            this.pictureEditBox.MouseLeave += new System.EventHandler(this.pictureEditBox_MouseLeave);
            // 
            // pictureDeleteBox
            // 
            this.pictureDeleteBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.pictureDeleteBox.Image = global::NoteAppUI.Properties.Resources.delete_unfocus;
            this.pictureDeleteBox.Location = new System.Drawing.Point(115, 603);
            this.pictureDeleteBox.Name = "pictureDeleteBox";
            this.pictureDeleteBox.Size = new System.Drawing.Size(41, 40);
            this.pictureDeleteBox.TabIndex = 8;
            this.pictureDeleteBox.TabStop = false;
            this.pictureDeleteBox.Click += new System.EventHandler(this.pictureDeleteBox_Click);
            this.pictureDeleteBox.MouseEnter += new System.EventHandler(this.pictureDeleteBox_MouseEnter);
            this.pictureDeleteBox.MouseLeave += new System.EventHandler(this.pictureDeleteBox_MouseLeave);
            // 
            // pictureCreateBox
            // 
            this.pictureCreateBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.pictureCreateBox.Image = global::NoteAppUI.Properties.Resources.create_unfocus;
            this.pictureCreateBox.Location = new System.Drawing.Point(18, 603);
            this.pictureCreateBox.Name = "pictureCreateBox";
            this.pictureCreateBox.Size = new System.Drawing.Size(41, 40);
            this.pictureCreateBox.TabIndex = 8;
            this.pictureCreateBox.TabStop = false;
            this.pictureCreateBox.Click += new System.EventHandler(this.pictureCreateBox_Click);
            this.pictureCreateBox.MouseEnter += new System.EventHandler(this.pictureCreateBox_MouseEnter);
            this.pictureCreateBox.MouseLeave += new System.EventHandler(this.pictureCreateBox_MouseLeave);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1214, 655);
            this.Controls.Add(this.pictureEditBox);
            this.Controls.Add(this.pictureDeleteBox);
            this.Controls.Add(this.pictureCreateBox);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(1232, 677);
            this.Name = "MainForm";
            this.Text = "Edit";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEditBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureDeleteBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureCreateBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem файлToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem изменитьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem помощьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem оПрограммеToolStripMenuItem;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ListBox listNoteBox;
        private System.Windows.Forms.ComboBox CategoryBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox contentBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dateTimeCreate;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label categoryLabel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label noteLabel;
        private System.Windows.Forms.ToolStripMenuItem закрытьПриложениеToolStripMenuItem;
        private System.Windows.Forms.DateTimePicker dateTimeUpdate;
        private System.Windows.Forms.Label errorLabel;
        private System.Windows.Forms.PictureBox pictureCreateBox;
        private System.Windows.Forms.PictureBox pictureDeleteBox;
        private System.Windows.Forms.PictureBox pictureEditBox;
    }
}