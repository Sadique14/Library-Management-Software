namespace Library_Management
{
    partial class LibIntroduction
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LibIntroduction));
            this.newBookButton = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.responseButton = new System.Windows.Forms.Button();
            this.seeRequestButton = new System.Windows.Forms.Button();
            this.borrowedBooksButton = new System.Windows.Forms.Button();
            this.studentInformationButton = new System.Windows.Forms.Button();
            this.ItemManagementbutton = new System.Windows.Forms.Button();
            this.newStudentbutton = new System.Windows.Forms.Button();
            this.listView2 = new System.Windows.Forms.ListView();
            this.book_id = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.title = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.author = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.popularity = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.quantity = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Condition = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.deadline = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.allButton = new System.Windows.Forms.Button();
            this.sectionComboBox = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.newYearButton = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // newBookButton
            // 
            this.newBookButton.Location = new System.Drawing.Point(13, 45);
            this.newBookButton.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.newBookButton.Name = "newBookButton";
            this.newBookButton.Padding = new System.Windows.Forms.Padding(2);
            this.newBookButton.Size = new System.Drawing.Size(244, 45);
            this.newBookButton.TabIndex = 0;
            this.newBookButton.Text = "NEW BOOK ENTRY";
            this.newBookButton.UseVisualStyleBackColor = true;
            this.newBookButton.Click += new System.EventHandler(this.newBookButton_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.responseButton);
            this.groupBox1.Controls.Add(this.seeRequestButton);
            this.groupBox1.Controls.Add(this.borrowedBooksButton);
            this.groupBox1.Controls.Add(this.studentInformationButton);
            this.groupBox1.Controls.Add(this.ItemManagementbutton);
            this.groupBox1.Controls.Add(this.newStudentbutton);
            this.groupBox1.Controls.Add(this.newBookButton);
            this.groupBox1.Font = new System.Drawing.Font("Lucida Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(0, 13);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBox1.Size = new System.Drawing.Size(267, 443);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Controll";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // responseButton
            // 
            this.responseButton.Location = new System.Drawing.Point(13, 275);
            this.responseButton.Name = "responseButton";
            this.responseButton.Padding = new System.Windows.Forms.Padding(2);
            this.responseButton.Size = new System.Drawing.Size(244, 45);
            this.responseButton.TabIndex = 6;
            this.responseButton.Text = "STUDENT RESPONSE";
            this.responseButton.UseVisualStyleBackColor = true;
            this.responseButton.Click += new System.EventHandler(this.responseButton_Click);
            // 
            // seeRequestButton
            // 
            this.seeRequestButton.Location = new System.Drawing.Point(12, 321);
            this.seeRequestButton.Name = "seeRequestButton";
            this.seeRequestButton.Padding = new System.Windows.Forms.Padding(2);
            this.seeRequestButton.Size = new System.Drawing.Size(244, 45);
            this.seeRequestButton.TabIndex = 5;
            this.seeRequestButton.Text = "REQUESTS";
            this.seeRequestButton.UseVisualStyleBackColor = true;
            this.seeRequestButton.Click += new System.EventHandler(this.seeRequestButton_Click);
            // 
            // borrowedBooksButton
            // 
            this.borrowedBooksButton.Location = new System.Drawing.Point(14, 229);
            this.borrowedBooksButton.Name = "borrowedBooksButton";
            this.borrowedBooksButton.Padding = new System.Windows.Forms.Padding(2);
            this.borrowedBooksButton.Size = new System.Drawing.Size(244, 45);
            this.borrowedBooksButton.TabIndex = 4;
            this.borrowedBooksButton.Text = "BORROWED BOOKS";
            this.borrowedBooksButton.UseVisualStyleBackColor = true;
            this.borrowedBooksButton.Click += new System.EventHandler(this.borrowedBooksButton_Click);
            // 
            // studentInformationButton
            // 
            this.studentInformationButton.Location = new System.Drawing.Point(14, 184);
            this.studentInformationButton.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.studentInformationButton.Name = "studentInformationButton";
            this.studentInformationButton.Padding = new System.Windows.Forms.Padding(2);
            this.studentInformationButton.Size = new System.Drawing.Size(244, 45);
            this.studentInformationButton.TabIndex = 3;
            this.studentInformationButton.Text = "STUDENT INFORMATION";
            this.studentInformationButton.UseVisualStyleBackColor = true;
            this.studentInformationButton.Click += new System.EventHandler(this.studentInformationButton_Click);
            // 
            // ItemManagementbutton
            // 
            this.ItemManagementbutton.Location = new System.Drawing.Point(14, 137);
            this.ItemManagementbutton.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.ItemManagementbutton.Name = "ItemManagementbutton";
            this.ItemManagementbutton.Padding = new System.Windows.Forms.Padding(2);
            this.ItemManagementbutton.Size = new System.Drawing.Size(244, 45);
            this.ItemManagementbutton.TabIndex = 2;
            this.ItemManagementbutton.Text = "EDIT SELECTED BOOK";
            this.ItemManagementbutton.UseVisualStyleBackColor = true;
            this.ItemManagementbutton.Click += new System.EventHandler(this.ItemManagementbutton_Click);
            // 
            // newStudentbutton
            // 
            this.newStudentbutton.Location = new System.Drawing.Point(13, 91);
            this.newStudentbutton.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.newStudentbutton.Name = "newStudentbutton";
            this.newStudentbutton.Padding = new System.Windows.Forms.Padding(2);
            this.newStudentbutton.Size = new System.Drawing.Size(244, 45);
            this.newStudentbutton.TabIndex = 1;
            this.newStudentbutton.Text = "NEW STUDENT ENTRY";
            this.newStudentbutton.UseVisualStyleBackColor = true;
            this.newStudentbutton.Click += new System.EventHandler(this.newStudentbutton_Click_1);
            // 
            // listView2
            // 
            this.listView2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.listView2.BackColor = System.Drawing.SystemColors.Window;
            this.listView2.CheckBoxes = true;
            this.listView2.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.book_id,
            this.title,
            this.author,
            this.popularity,
            this.quantity,
            this.Condition,
            this.deadline});
            this.listView2.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listView2.FullRowSelect = true;
            this.listView2.GridLines = true;
            this.listView2.HoverSelection = true;
            this.listView2.Location = new System.Drawing.Point(274, 67);
            this.listView2.Name = "listView2";
            this.listView2.Size = new System.Drawing.Size(1024, 389);
            this.listView2.TabIndex = 15;
            this.listView2.UseCompatibleStateImageBehavior = false;
            this.listView2.View = System.Windows.Forms.View.Details;
            // 
            // book_id
            // 
            this.book_id.Text = "Book ID";
            this.book_id.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // title
            // 
            this.title.Text = "Title of The Book";
            this.title.Width = 220;
            // 
            // author
            // 
            this.author.Text = "Author";
            this.author.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.author.Width = 350;
            // 
            // popularity
            // 
            this.popularity.Text = "Popularity";
            this.popularity.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.popularity.Width = 100;
            // 
            // quantity
            // 
            this.quantity.Text = "Quantity";
            this.quantity.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Condition
            // 
            this.Condition.Text = "Condition";
            this.Condition.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Condition.Width = 100;
            // 
            // deadline
            // 
            this.deadline.Text = "Return Time (days)";
            this.deadline.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.deadline.Width = 130;
            // 
            // allButton
            // 
            this.allButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.allButton.BackColor = System.Drawing.Color.Transparent;
            this.allButton.Font = new System.Drawing.Font("Lucida Sans Unicode", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.allButton.Location = new System.Drawing.Point(274, 23);
            this.allButton.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.allButton.Name = "allButton";
            this.allButton.Size = new System.Drawing.Size(173, 38);
            this.allButton.TabIndex = 16;
            this.allButton.Text = "SHOW ALL BOOKS";
            this.allButton.UseVisualStyleBackColor = true;
            this.allButton.Click += new System.EventHandler(this.allButton_Click);
            // 
            // sectionComboBox
            // 
            this.sectionComboBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.sectionComboBox.Font = new System.Drawing.Font("Lucida Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sectionComboBox.FormattingEnabled = true;
            this.sectionComboBox.Location = new System.Drawing.Point(534, 32);
            this.sectionComboBox.Name = "sectionComboBox";
            this.sectionComboBox.Size = new System.Drawing.Size(374, 23);
            this.sectionComboBox.TabIndex = 18;
            this.sectionComboBox.SelectedIndexChanged += new System.EventHandler(this.sectionComboBox_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Lucida Sans Typewriter", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(465, 34);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 15);
            this.label2.TabIndex = 17;
            this.label2.Text = "Section";
            // 
            // newYearButton
            // 
            this.newYearButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.newYearButton.BackColor = System.Drawing.Color.IndianRed;
            this.newYearButton.Location = new System.Drawing.Point(1053, 472);
            this.newYearButton.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.newYearButton.Name = "newYearButton";
            this.newYearButton.Size = new System.Drawing.Size(245, 43);
            this.newYearButton.TabIndex = 3;
            this.newYearButton.Text = "NEW YEAR";
            this.newYearButton.UseVisualStyleBackColor = false;
            this.newYearButton.Click += new System.EventHandler(this.newYearButton_Click);
            // 
            // LibIntroduction
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1326, 525);
            this.Controls.Add(this.newYearButton);
            this.Controls.Add(this.sectionComboBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.allButton);
            this.Controls.Add(this.listView2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Lucida Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "LibIntroduction";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Librarian Page";
            this.Load += new System.EventHandler(this.Introduction_Load);
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button newBookButton;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button studentInformationButton;
        private System.Windows.Forms.Button ItemManagementbutton;
        private System.Windows.Forms.Button newStudentbutton;
        private System.Windows.Forms.ListView listView2;
        private System.Windows.Forms.ColumnHeader book_id;
        private System.Windows.Forms.ColumnHeader title;
        private System.Windows.Forms.ColumnHeader author;
        private System.Windows.Forms.ColumnHeader popularity;
        private System.Windows.Forms.ColumnHeader quantity;
        private System.Windows.Forms.ColumnHeader Condition;
        private System.Windows.Forms.ColumnHeader deadline;
        private System.Windows.Forms.Button allButton;
        private System.Windows.Forms.ComboBox sectionComboBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button newYearButton;
        private System.Windows.Forms.Button borrowedBooksButton;
        private System.Windows.Forms.Button seeRequestButton;
        private System.Windows.Forms.Button responseButton;
    }
}