namespace NoteAppUI
{
    partial class NoteForm
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
            System.Windows.Forms.ListViewGroup listViewGroup1 = new System.Windows.Forms.ListViewGroup("ListViewGroup", System.Windows.Forms.HorizontalAlignment.Left);
            System.Windows.Forms.ListViewItem listViewItem1 = new System.Windows.Forms.ListViewItem(new string[] {
            "❤"}, -1, System.Drawing.Color.Empty, System.Drawing.Color.Empty, new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204))));
            System.Windows.Forms.ListViewItem listViewItem2 = new System.Windows.Forms.ListViewItem(new string[] {
            "☺"}, -1, System.Drawing.Color.Empty, System.Drawing.Color.Empty, new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204))));
            System.Windows.Forms.ListViewItem listViewItem3 = new System.Windows.Forms.ListViewItem(new string[] {
            "☹"}, -1, System.Drawing.Color.Empty, System.Drawing.Color.Empty, new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204))));
            System.Windows.Forms.ListViewItem listViewItem4 = new System.Windows.Forms.ListViewItem(new string[] {
            "☛"}, -1, System.Drawing.Color.Empty, System.Drawing.Color.Empty, new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204))));
            System.Windows.Forms.ListViewItem listViewItem5 = new System.Windows.Forms.ListViewItem(new string[] {
            "✐"}, -1, System.Drawing.Color.Empty, System.Drawing.Color.Empty, new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204))));
            System.Windows.Forms.ListViewItem listViewItem6 = new System.Windows.Forms.ListViewItem(new string[] {
            "☏"}, -1, System.Drawing.Color.Empty, System.Drawing.Color.Empty, new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204))));
            System.Windows.Forms.ListViewItem listViewItem7 = new System.Windows.Forms.ListViewItem(new string[] {
            "●"}, -1, System.Drawing.Color.Empty, System.Drawing.Color.Empty, new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204))));
            System.Windows.Forms.ListViewItem listViewItem8 = new System.Windows.Forms.ListViewItem(new string[] {
            "⚘"}, -1, System.Drawing.Color.Empty, System.Drawing.Color.Empty, new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204))));
            System.Windows.Forms.ListViewItem listViewItem9 = new System.Windows.Forms.ListViewItem(new string[] {
            "♫"}, -1, System.Drawing.Color.Empty, System.Drawing.Color.Empty, new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204))));
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NoteForm));
            this.labelNoteTitle = new System.Windows.Forms.Label();
            this.saveButton = new System.Windows.Forms.Button();
            this.dateTimeUpdate = new System.Windows.Forms.DateTimePicker();
            this.noteTextBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.backButton = new System.Windows.Forms.Button();
            this.titleTextBox = new System.Windows.Forms.TextBox();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.CategoryComboBox = new System.Windows.Forms.ComboBox();
            this.dateTimeCreate = new System.Windows.Forms.DateTimePicker();
            this.emojiListView = new System.Windows.Forms.ListView();
            this.emojiButton = new NoteAppUI.RoundPictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.emojiButton)).BeginInit();
            this.SuspendLayout();
            // 
            // labelNoteTitle
            // 
            this.labelNoteTitle.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelNoteTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNoteTitle.Location = new System.Drawing.Point(12, 9);
            this.labelNoteTitle.Name = "labelNoteTitle";
            this.labelNoteTitle.Size = new System.Drawing.Size(615, 32);
            this.labelNoteTitle.TabIndex = 0;
            this.labelNoteTitle.Text = "ЗАМЕТКА";
            this.labelNoteTitle.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // saveButton
            // 
            this.saveButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.saveButton.Location = new System.Drawing.Point(357, 522);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(134, 31);
            this.saveButton.TabIndex = 6;
            this.saveButton.Text = "Сохранить";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // dateTimeUpdate
            // 
            this.dateTimeUpdate.CustomFormat = "HH:mm  dd.MMM.2kyy";
            this.dateTimeUpdate.Enabled = false;
            this.dateTimeUpdate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimeUpdate.Location = new System.Drawing.Point(442, 110);
            this.dateTimeUpdate.Name = "dateTimeUpdate";
            this.dateTimeUpdate.Size = new System.Drawing.Size(185, 22);
            this.dateTimeUpdate.TabIndex = 4;
            // 
            // noteTextBox
            // 
            this.noteTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.noteTextBox.Location = new System.Drawing.Point(12, 141);
            this.noteTextBox.Multiline = true;
            this.noteTextBox.Name = "noteTextBox";
            this.noteTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.noteTextBox.Size = new System.Drawing.Size(615, 372);
            this.noteTextBox.TabIndex = 5;
            this.noteTextBox.TextChanged += new System.EventHandler(this.noteTextBox_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(317, 113);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(122, 17);
            this.label5.TabIndex = 40;
            this.label5.Text = "Дата изменения:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 17);
            this.label2.TabIndex = 33;
            this.label2.Text = "Заголовок:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 113);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(112, 17);
            this.label4.TabIndex = 39;
            this.label4.Text = "Дата создания:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 81);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 17);
            this.label3.TabIndex = 34;
            this.label3.Text = "Категория:";
            // 
            // backButton
            // 
            this.backButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.backButton.Location = new System.Drawing.Point(497, 522);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(134, 31);
            this.backButton.TabIndex = 7;
            this.backButton.Text = "Назад";
            this.backButton.UseVisualStyleBackColor = true;
            this.backButton.Click += new System.EventHandler(this.backButton_Click);
            // 
            // titleTextBox
            // 
            this.titleTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.titleTextBox.Location = new System.Drawing.Point(123, 45);
            this.titleTextBox.MaxLength = 50;
            this.titleTextBox.Name = "titleTextBox";
            this.titleTextBox.Size = new System.Drawing.Size(504, 22);
            this.titleTextBox.TabIndex = 1;
            this.titleTextBox.TextChanged += new System.EventHandler(this.titleTextBox_TextChanged);
            // 
            // toolTip
            // 
            this.toolTip.BackColor = System.Drawing.Color.Tomato;
            // 
            // CategoryComboBox
            // 
            this.CategoryComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CategoryComboBox.FormattingEnabled = true;
            this.CategoryComboBox.Location = new System.Drawing.Point(123, 77);
            this.CategoryComboBox.Name = "CategoryComboBox";
            this.CategoryComboBox.Size = new System.Drawing.Size(185, 24);
            this.CategoryComboBox.TabIndex = 2;
            this.CategoryComboBox.SelectedIndexChanged += new System.EventHandler(this.CategoryComboBox_SelectedIndexChanged);
            // 
            // dateTimeCreate
            // 
            this.dateTimeCreate.CustomFormat = "HH:mm  dd.MMM.2kyy";
            this.dateTimeCreate.Enabled = false;
            this.dateTimeCreate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimeCreate.Location = new System.Drawing.Point(123, 110);
            this.dateTimeCreate.Name = "dateTimeCreate";
            this.dateTimeCreate.Size = new System.Drawing.Size(185, 22);
            this.dateTimeCreate.TabIndex = 3;
            // 
            // emojiListView
            // 
            this.emojiListView.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.emojiListView.Cursor = System.Windows.Forms.Cursors.Hand;
            listViewGroup1.Header = "ListViewGroup";
            listViewGroup1.Name = "listViewGroup1";
            this.emojiListView.Groups.AddRange(new System.Windows.Forms.ListViewGroup[] {
            listViewGroup1});
            this.emojiListView.HideSelection = false;
            this.emojiListView.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem1,
            listViewItem2,
            listViewItem3,
            listViewItem4,
            listViewItem5,
            listViewItem6,
            listViewItem7,
            listViewItem8,
            listViewItem9});
            this.emojiListView.Location = new System.Drawing.Point(412, 298);
            this.emojiListView.Name = "emojiListView";
            this.emojiListView.Size = new System.Drawing.Size(192, 173);
            this.emojiListView.TabIndex = 48;
            this.emojiListView.UseCompatibleStateImageBehavior = false;
            this.emojiListView.Visible = false;
            this.emojiListView.SelectedIndexChanged += new System.EventHandler(this.emojiListView_SelectedIndexChanged);
            // 
            // emojiButton
            // 
            this.emojiButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.emojiButton.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.emojiButton.Image = global::NoteAppUI.Properties.Resources.emoji_unfocus;
            this.emojiButton.Location = new System.Drawing.Point(564, 473);
            this.emojiButton.Name = "emojiButton";
            this.emojiButton.Size = new System.Drawing.Size(39, 38);
            this.emojiButton.TabIndex = 51;
            this.emojiButton.TabStop = false;
            this.emojiButton.Click += new System.EventHandler(this.emojiButton_Click);
            this.emojiButton.MouseEnter += new System.EventHandler(this.emojiButton_MouseEnter);
            this.emojiButton.MouseLeave += new System.EventHandler(this.emojiButton_MouseLeave);
            // 
            // NoteForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(642, 565);
            this.Controls.Add(this.emojiButton);
            this.Controls.Add(this.emojiListView);
            this.Controls.Add(this.dateTimeCreate);
            this.Controls.Add(this.CategoryComboBox);
            this.Controls.Add(this.titleTextBox);
            this.Controls.Add(this.backButton);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.dateTimeUpdate);
            this.Controls.Add(this.noteTextBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.labelNoteTitle);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(660, 612);
            this.Name = "NoteForm";
            this.Text = "Создать или изменить заметку";
            this.Load += new System.EventHandler(this.NoteForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.emojiButton)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelNoteTitle;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.DateTimePicker dateTimeUpdate;
        private System.Windows.Forms.TextBox noteTextBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button backButton;
        private System.Windows.Forms.TextBox titleTextBox;
        private System.Windows.Forms.ToolTip toolTip;
        private System.Windows.Forms.ComboBox CategoryComboBox;
        private System.Windows.Forms.DateTimePicker dateTimeCreate;
        private System.Windows.Forms.ListView emojiListView;
        private RoundPictureBox emojiButton;
    }
}