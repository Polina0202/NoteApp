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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NoteForm));
            this.labelNoteTitle = new System.Windows.Forms.Label();
            this.saveButton = new System.Windows.Forms.Button();
            this.dateTimeUpdate = new System.Windows.Forms.DateTimePicker();
            this.noteBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dateTimeCreate = new System.Windows.Forms.DateTimePicker();
            this.backButton = new System.Windows.Forms.Button();
            this.titleBox = new System.Windows.Forms.TextBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.CategoryComboBox = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // labelNoteTitle
            // 
            this.labelNoteTitle.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelNoteTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNoteTitle.Location = new System.Drawing.Point(15, 20);
            this.labelNoteTitle.Name = "labelNoteTitle";
            this.labelNoteTitle.Size = new System.Drawing.Size(623, 32);
            this.labelNoteTitle.TabIndex = 0;
            this.labelNoteTitle.Text = "ЗАМЕТКА";
            this.labelNoteTitle.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // saveButton
            // 
            this.saveButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.saveButton.Location = new System.Drawing.Point(364, 610);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(134, 31);
            this.saveButton.TabIndex = 42;
            this.saveButton.Text = "Сохранить";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // dateTimeUpdate
            // 
            this.dateTimeUpdate.CustomFormat = "HH:mm  dd.MMM.2kyy";
            this.dateTimeUpdate.Enabled = false;
            this.dateTimeUpdate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimeUpdate.Location = new System.Drawing.Point(453, 130);
            this.dateTimeUpdate.Name = "dateTimeUpdate";
            this.dateTimeUpdate.Size = new System.Drawing.Size(185, 22);
            this.dateTimeUpdate.TabIndex = 41;
            // 
            // noteBox
            // 
            this.noteBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.noteBox.Location = new System.Drawing.Point(12, 158);
            this.noteBox.Multiline = true;
            this.noteBox.Name = "noteBox";
            this.noteBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.noteBox.Size = new System.Drawing.Size(626, 446);
            this.noteBox.TabIndex = 38;
            this.noteBox.TextChanged += new System.EventHandler(this.noteBox_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(325, 130);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(122, 17);
            this.label5.TabIndex = 40;
            this.label5.Text = "Дата изменения:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 17);
            this.label2.TabIndex = 33;
            this.label2.Text = "Заголовок:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 130);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(112, 17);
            this.label4.TabIndex = 39;
            this.label4.Text = "Дата создания:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 100);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 17);
            this.label3.TabIndex = 34;
            this.label3.Text = "Категория:";
            // 
            // dateTimeCreate
            // 
            this.dateTimeCreate.CustomFormat = "HH:mm  dd.MMM.2kyy";
            this.dateTimeCreate.Enabled = false;
            this.dateTimeCreate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimeCreate.Location = new System.Drawing.Point(130, 130);
            this.dateTimeCreate.Name = "dateTimeCreate";
            this.dateTimeCreate.Size = new System.Drawing.Size(185, 22);
            this.dateTimeCreate.TabIndex = 37;
            // 
            // backButton
            // 
            this.backButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.backButton.Location = new System.Drawing.Point(506, 610);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(134, 31);
            this.backButton.TabIndex = 44;
            this.backButton.Text = "Назад";
            this.backButton.UseVisualStyleBackColor = true;
            this.backButton.Click += new System.EventHandler(this.backButton_Click);
            // 
            // titleBox
            // 
            this.titleBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.titleBox.Location = new System.Drawing.Point(130, 72);
            this.titleBox.MaxLength = 50;
            this.titleBox.Name = "titleBox";
            this.titleBox.Size = new System.Drawing.Size(508, 22);
            this.titleBox.TabIndex = 45;
            this.titleBox.TextChanged += new System.EventHandler(this.titleBox_TextChanged);
            // 
            // toolTip1
            // 
            this.toolTip1.BackColor = System.Drawing.Color.Tomato;
            // 
            // CategoryComboBox
            // 
            this.CategoryComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CategoryComboBox.FormattingEnabled = true;
            this.CategoryComboBox.Location = new System.Drawing.Point(130, 97);
            this.CategoryComboBox.Name = "CategoryComboBox";
            this.CategoryComboBox.Size = new System.Drawing.Size(185, 24);
            this.CategoryComboBox.TabIndex = 46;
            this.CategoryComboBox.SelectedIndexChanged += new System.EventHandler(this.CategoryComboBox_SelectedIndexChanged);
            // 
            // NoteForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(652, 653);
            this.Controls.Add(this.CategoryComboBox);
            this.Controls.Add(this.titleBox);
            this.Controls.Add(this.backButton);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.dateTimeUpdate);
            this.Controls.Add(this.noteBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dateTimeCreate);
            this.Controls.Add(this.labelNoteTitle);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(670, 700);
            this.Name = "NoteForm";
            this.Text = "Создать или изменить заметку";
            this.Load += new System.EventHandler(this.NoteForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelNoteTitle;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.DateTimePicker dateTimeUpdate;
        private System.Windows.Forms.TextBox noteBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dateTimeCreate;
        private System.Windows.Forms.Button backButton;
        private System.Windows.Forms.TextBox titleBox;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.ComboBox CategoryComboBox;
    }
}