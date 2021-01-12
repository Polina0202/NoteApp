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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.closeAppToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.changeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.abourProgramToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1 = new System.Windows.Forms.Panel();
            this.noteListBox = new System.Windows.Forms.ListBox();
            this.CategoryComboBox = new System.Windows.Forms.ComboBox();
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
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.pictureEditBox = new System.Windows.Forms.PictureBox();
            this.pictureDeleteBox = new System.Windows.Forms.PictureBox();
            this.pictureCreateBox = new System.Windows.Forms.PictureBox();
            this.menuStrip.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEditBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureDeleteBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureCreateBox)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip
            // 
            this.menuStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.changeToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(1173, 28);
            this.menuStrip.TabIndex = 13;
            this.menuStrip.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.closeAppToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(57, 24);
            this.fileToolStripMenuItem.Text = "Файл";
            // 
            // closeAppToolStripMenuItem
            // 
            this.closeAppToolStripMenuItem.Name = "closeAppToolStripMenuItem";
            this.closeAppToolStripMenuItem.Size = new System.Drawing.Size(234, 26);
            this.closeAppToolStripMenuItem.Text = "Закрыть приложение";
            this.closeAppToolStripMenuItem.Click += new System.EventHandler(this.closeAppToolStripMenuItem_Click);
            // 
            // changeToolStripMenuItem
            // 
            this.changeToolStripMenuItem.Name = "changeToolStripMenuItem";
            this.changeToolStripMenuItem.Size = new System.Drawing.Size(90, 24);
            this.changeToolStripMenuItem.Text = "Изменить";
            this.changeToolStripMenuItem.Click += new System.EventHandler(this.changeToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.abourProgramToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(81, 24);
            this.helpToolStripMenuItem.Text = "Помощь";
            // 
            // abourProgramToolStripMenuItem
            // 
            this.abourProgramToolStripMenuItem.Name = "abourProgramToolStripMenuItem";
            this.abourProgramToolStripMenuItem.Size = new System.Drawing.Size(179, 26);
            this.abourProgramToolStripMenuItem.Text = "О программе";
            this.abourProgramToolStripMenuItem.Click += new System.EventHandler(this.aboutProgramToolStripMenuItem_Click);
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.panel1.Controls.Add(this.noteListBox);
            this.panel1.Controls.Add(this.CategoryComboBox);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(0, 32);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(447, 513);
            this.panel1.TabIndex = 14;
            // 
            // noteListBox
            // 
            this.noteListBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.noteListBox.FormattingEnabled = true;
            this.noteListBox.ItemHeight = 16;
            this.noteListBox.Location = new System.Drawing.Point(12, 46);
            this.noteListBox.Name = "noteListBox";
            this.noteListBox.ScrollAlwaysVisible = true;
            this.noteListBox.Size = new System.Drawing.Size(428, 436);
            this.noteListBox.TabIndex = 2;
            this.noteListBox.SelectedIndexChanged += new System.EventHandler(this.noteListBox_SelectedIndexChanged);
            // 
            // CategoryComboBox
            // 
            this.CategoryComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CategoryComboBox.FormattingEnabled = true;
            this.CategoryComboBox.Location = new System.Drawing.Point(224, 11);
            this.CategoryComboBox.Name = "CategoryComboBox";
            this.CategoryComboBox.Size = new System.Drawing.Size(216, 24);
            this.CategoryComboBox.TabIndex = 1;
            this.CategoryComboBox.SelectedIndexChanged += new System.EventHandler(this.CategoryComboBox_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 16);
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
            this.panel2.Location = new System.Drawing.Point(446, 32);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(727, 578);
            this.panel2.TabIndex = 15;
            // 
            // dateTimeUpdate
            // 
            this.dateTimeUpdate.CustomFormat = "HH:mm  dd.MMM.2kyy";
            this.dateTimeUpdate.Enabled = false;
            this.dateTimeUpdate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimeUpdate.Location = new System.Drawing.Point(520, 68);
            this.dateTimeUpdate.Name = "dateTimeUpdate";
            this.dateTimeUpdate.Size = new System.Drawing.Size(193, 22);
            this.dateTimeUpdate.TabIndex = 7;
            this.dateTimeUpdate.Value = new System.DateTime(2020, 1, 1, 0, 0, 0, 0);
            // 
            // contentBox
            // 
            this.contentBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.contentBox.Location = new System.Drawing.Point(10, 101);
            this.contentBox.Multiline = true;
            this.contentBox.Name = "contentBox";
            this.contentBox.ReadOnly = true;
            this.contentBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.contentBox.Size = new System.Drawing.Size(702, 458);
            this.contentBox.TabIndex = 0;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(313, 72);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(202, 17);
            this.label4.TabIndex = 6;
            this.label4.Text = "Дата последнего изменения:";
            // 
            // dateTimeCreate
            // 
            this.dateTimeCreate.CustomFormat = "HH:mm  dd.MMM.2kyy";
            this.dateTimeCreate.Enabled = false;
            this.dateTimeCreate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimeCreate.Location = new System.Drawing.Point(121, 68);
            this.dateTimeCreate.Name = "dateTimeCreate";
            this.dateTimeCreate.Size = new System.Drawing.Size(190, 22);
            this.dateTimeCreate.TabIndex = 4;
            this.dateTimeCreate.Value = new System.DateTime(2020, 1, 1, 0, 0, 0, 0);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(112, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Дата создания:";
            // 
            // categoryLabel
            // 
            this.categoryLabel.AutoSize = true;
            this.categoryLabel.Location = new System.Drawing.Point(85, 42);
            this.categoryLabel.Name = "categoryLabel";
            this.categoryLabel.Size = new System.Drawing.Size(77, 17);
            this.categoryLabel.TabIndex = 2;
            this.categoryLabel.Text = "Категория";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(8, 42);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 17);
            this.label3.TabIndex = 1;
            this.label3.Text = "Категория:";
            // 
            // noteLabel
            // 
            this.noteLabel.AutoSize = true;
            this.noteLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.noteLabel.Location = new System.Drawing.Point(5, 3);
            this.noteLabel.Name = "noteLabel";
            this.noteLabel.Size = new System.Drawing.Size(162, 32);
            this.noteLabel.TabIndex = 0;
            this.noteLabel.Text = "Заголовок";
            // 
            // pictureEditBox
            // 
            this.pictureEditBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.pictureEditBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureEditBox.Image = global::NoteAppUI.Properties.Resources.edit_unfocus;
            this.pictureEditBox.Location = new System.Drawing.Point(118, 544);
            this.pictureEditBox.Name = "pictureEditBox";
            this.pictureEditBox.Size = new System.Drawing.Size(53, 47);
            this.pictureEditBox.TabIndex = 8;
            this.pictureEditBox.TabStop = false;
            this.pictureEditBox.Click += new System.EventHandler(this.pictureEditBox_Click);
            this.pictureEditBox.MouseEnter += new System.EventHandler(this.pictureEditBox_MouseEnter);
            this.pictureEditBox.MouseLeave += new System.EventHandler(this.pictureEditBox_MouseLeave);
            // 
            // pictureDeleteBox
            // 
            this.pictureDeleteBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.pictureDeleteBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureDeleteBox.Image = global::NoteAppUI.Properties.Resources.delete_unfocus;
            this.pictureDeleteBox.Location = new System.Drawing.Point(65, 544);
            this.pictureDeleteBox.Name = "pictureDeleteBox";
            this.pictureDeleteBox.Size = new System.Drawing.Size(47, 47);
            this.pictureDeleteBox.TabIndex = 8;
            this.pictureDeleteBox.TabStop = false;
            this.pictureDeleteBox.Click += new System.EventHandler(this.pictureDeleteBox_Click);
            this.pictureDeleteBox.MouseEnter += new System.EventHandler(this.pictureDeleteBox_MouseEnter);
            this.pictureDeleteBox.MouseLeave += new System.EventHandler(this.pictureDeleteBox_MouseLeave);
            // 
            // pictureCreateBox
            // 
            this.pictureCreateBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.pictureCreateBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureCreateBox.Image = global::NoteAppUI.Properties.Resources.create_unfocus;
            this.pictureCreateBox.Location = new System.Drawing.Point(12, 544);
            this.pictureCreateBox.Name = "pictureCreateBox";
            this.pictureCreateBox.Size = new System.Drawing.Size(47, 47);
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
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1173, 603);
            this.Controls.Add(this.pictureEditBox);
            this.Controls.Add(this.pictureDeleteBox);
            this.Controls.Add(this.pictureCreateBox);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuStrip);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(1191, 650);
            this.Name = "MainForm";
            this.Text = "Коллекция ваших заметок";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MainForm_FormClosed);
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
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

        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem changeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem abourProgramToolStripMenuItem;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ListBox noteListBox;
        private System.Windows.Forms.ComboBox CategoryComboBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox contentBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dateTimeCreate;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label categoryLabel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label noteLabel;
        private System.Windows.Forms.ToolStripMenuItem closeAppToolStripMenuItem;
        private System.Windows.Forms.DateTimePicker dateTimeUpdate;
        private System.Windows.Forms.PictureBox pictureCreateBox;
        private System.Windows.Forms.PictureBox pictureDeleteBox;
        private System.Windows.Forms.PictureBox pictureEditBox;
        private System.Windows.Forms.ToolTip toolTip;
    }
}