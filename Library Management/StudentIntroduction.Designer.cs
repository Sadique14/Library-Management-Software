namespace Library_Management
{
    partial class StudentIntroduction
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StudentIntroduction));
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.logOutButton = new System.Windows.Forms.Button();
            this.seeSectionButton = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.requestBox = new System.Windows.Forms.TextBox();
            this.requestButton = new System.Windows.Forms.Button();
            this.newCardButton = new System.Windows.Forms.Button();
            this.libraryCardShowbutton = new System.Windows.Forms.Button();
            this.borrowedBooksButton = new System.Windows.Forms.Button();
            this.updateButton = new System.Windows.Forms.Button();
            this.borrowButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.sectionComboBox = new System.Windows.Forms.ComboBox();
            this.titleBox = new System.Windows.Forms.TextBox();
            this.searchButton = new System.Windows.Forms.Button();
            this.allButton = new System.Windows.Forms.Button();
            this.listView1 = new System.Windows.Forms.ListView();
            this.book_id = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.title = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.author = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.popularity = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.quantity = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Condition = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.deadline = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.NOTICE = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.smsPanel = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.replyBox = new System.Windows.Forms.TextBox();
            this.replyButton = new System.Windows.Forms.Button();
            this.clearButton = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.groupBox1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(496, 10);
            this.label1.Margin = new System.Windows.Forms.Padding(0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(321, 48);
            this.label1.TabIndex = 6;
            this.label1.Text = "             Seminar Library\r\nCSE Discipline, Khulna University";
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.logOutButton);
            this.groupBox1.Controls.Add(this.seeSectionButton);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.requestBox);
            this.groupBox1.Controls.Add(this.requestButton);
            this.groupBox1.Controls.Add(this.newCardButton);
            this.groupBox1.Controls.Add(this.libraryCardShowbutton);
            this.groupBox1.Controls.Add(this.borrowedBooksButton);
            this.groupBox1.Controls.Add(this.updateButton);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 135);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(292, 470);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Welcome";
            // 
            // logOutButton
            // 
            this.logOutButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logOutButton.Location = new System.Drawing.Point(6, 411);
            this.logOutButton.Name = "logOutButton";
            this.logOutButton.Size = new System.Drawing.Size(279, 47);
            this.logOutButton.TabIndex = 17;
            this.logOutButton.Text = "LOG OUT";
            this.logOutButton.UseVisualStyleBackColor = true;
            this.logOutButton.Click += new System.EventHandler(this.logOutButton_Click);
            // 
            // seeSectionButton
            // 
            this.seeSectionButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.seeSectionButton.Location = new System.Drawing.Point(6, 222);
            this.seeSectionButton.Name = "seeSectionButton";
            this.seeSectionButton.Size = new System.Drawing.Size(279, 47);
            this.seeSectionButton.TabIndex = 16;
            this.seeSectionButton.Text = "SECTIONS and LOCATIONS";
            this.seeSectionButton.UseVisualStyleBackColor = true;
            this.seeSectionButton.Click += new System.EventHandler(this.seeSectionButton_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 292);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(110, 16);
            this.label4.TabIndex = 15;
            this.label4.Text = "Request Book:";
            // 
            // requestBox
            // 
            this.requestBox.AcceptsReturn = true;
            this.requestBox.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.requestBox.Location = new System.Drawing.Point(6, 311);
            this.requestBox.Multiline = true;
            this.requestBox.Name = "requestBox";
            this.requestBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.requestBox.Size = new System.Drawing.Size(279, 48);
            this.requestBox.TabIndex = 14;
            // 
            // requestButton
            // 
            this.requestButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.requestButton.Location = new System.Drawing.Point(6, 365);
            this.requestButton.Name = "requestButton";
            this.requestButton.Size = new System.Drawing.Size(279, 40);
            this.requestButton.TabIndex = 5;
            this.requestButton.Text = "SEND REQUEST";
            this.requestButton.UseVisualStyleBackColor = true;
            this.requestButton.Click += new System.EventHandler(this.requestButton_Click);
            // 
            // newCardButton
            // 
            this.newCardButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.newCardButton.Location = new System.Drawing.Point(6, 176);
            this.newCardButton.Name = "newCardButton";
            this.newCardButton.Size = new System.Drawing.Size(279, 40);
            this.newCardButton.TabIndex = 3;
            this.newCardButton.Text = "NEW LIBRARY CARD";
            this.newCardButton.UseVisualStyleBackColor = true;
            this.newCardButton.Click += new System.EventHandler(this.newCardButton_Click);
            // 
            // libraryCardShowbutton
            // 
            this.libraryCardShowbutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.libraryCardShowbutton.Location = new System.Drawing.Point(6, 130);
            this.libraryCardShowbutton.Name = "libraryCardShowbutton";
            this.libraryCardShowbutton.Size = new System.Drawing.Size(279, 40);
            this.libraryCardShowbutton.TabIndex = 2;
            this.libraryCardShowbutton.Text = "LIBRARY CARDS";
            this.libraryCardShowbutton.UseVisualStyleBackColor = true;
            this.libraryCardShowbutton.Click += new System.EventHandler(this.libraryCardShowButton_Click);
            // 
            // borrowedBooksButton
            // 
            this.borrowedBooksButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.borrowedBooksButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.borrowedBooksButton.Location = new System.Drawing.Point(6, 84);
            this.borrowedBooksButton.Name = "borrowedBooksButton";
            this.borrowedBooksButton.Size = new System.Drawing.Size(280, 38);
            this.borrowedBooksButton.TabIndex = 15;
            this.borrowedBooksButton.Text = "BORROWED BOOKS LIST";
            this.borrowedBooksButton.UseVisualStyleBackColor = true;
            this.borrowedBooksButton.Click += new System.EventHandler(this.borrowedBooksButton_Click);
            // 
            // updateButton
            // 
            this.updateButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.updateButton.Location = new System.Drawing.Point(6, 38);
            this.updateButton.Name = "updateButton";
            this.updateButton.Size = new System.Drawing.Size(280, 40);
            this.updateButton.TabIndex = 1;
            this.updateButton.Text = "UPDATE INFORMATION";
            this.updateButton.UseVisualStyleBackColor = true;
            this.updateButton.Click += new System.EventHandler(this.updateButton_Click);
            // 
            // borrowButton
            // 
            this.borrowButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.borrowButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.borrowButton.Location = new System.Drawing.Point(492, 138);
            this.borrowButton.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.borrowButton.Name = "borrowButton";
            this.borrowButton.Size = new System.Drawing.Size(214, 39);
            this.borrowButton.TabIndex = 12;
            this.borrowButton.Text = "BORROW SELECTED BOOKS";
            this.borrowButton.UseVisualStyleBackColor = true;
            this.borrowButton.Click += new System.EventHandler(this.borrowButton_Click);
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Lucida Sans Typewriter", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(310, 114);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 15);
            this.label2.TabIndex = 7;
            this.label2.Text = "Section";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Lucida Sans Typewriter", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(759, 112);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 15);
            this.label3.TabIndex = 8;
            this.label3.Text = "Book Title";
            // 
            // sectionComboBox
            // 
            this.sectionComboBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.sectionComboBox.Font = new System.Drawing.Font("Lucida Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sectionComboBox.FormattingEnabled = true;
            this.sectionComboBox.Location = new System.Drawing.Point(379, 108);
            this.sectionComboBox.Name = "sectionComboBox";
            this.sectionComboBox.Size = new System.Drawing.Size(374, 23);
            this.sectionComboBox.TabIndex = 9;
            this.sectionComboBox.SelectedIndexChanged += new System.EventHandler(this.sectionComboBox_SelectedIndexChanged);
            // 
            // titleBox
            // 
            this.titleBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.titleBox.Font = new System.Drawing.Font("Lucida Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleBox.Location = new System.Drawing.Point(852, 110);
            this.titleBox.Name = "titleBox";
            this.titleBox.Size = new System.Drawing.Size(340, 23);
            this.titleBox.TabIndex = 10;
            // 
            // searchButton
            // 
            this.searchButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.searchButton.Location = new System.Drawing.Point(1198, 109);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(92, 24);
            this.searchButton.TabIndex = 11;
            this.searchButton.Text = "SEARCH";
            this.searchButton.UseVisualStyleBackColor = true;
            this.searchButton.Click += new System.EventHandler(this.searchButton_Click);
            // 
            // allButton
            // 
            this.allButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.allButton.BackColor = System.Drawing.Color.Transparent;
            this.allButton.Font = new System.Drawing.Font("Lucida Sans Unicode", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.allButton.Location = new System.Drawing.Point(311, 138);
            this.allButton.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.allButton.Name = "allButton";
            this.allButton.Size = new System.Drawing.Size(173, 38);
            this.allButton.TabIndex = 13;
            this.allButton.Text = "ALL BOOKS";
            this.allButton.UseVisualStyleBackColor = true;
            this.allButton.Click += new System.EventHandler(this.allButton_Click);
            // 
            // listView1
            // 
            this.listView1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.listView1.CheckBoxes = true;
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.book_id,
            this.title,
            this.author,
            this.popularity,
            this.quantity,
            this.Condition,
            this.deadline});
            this.listView1.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listView1.FullRowSelect = true;
            this.listView1.GridLines = true;
            this.listView1.HoverSelection = true;
            this.listView1.Location = new System.Drawing.Point(310, 182);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(1024, 425);
            this.listView1.TabIndex = 14;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
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
            // NOTICE
            // 
            this.NOTICE.AutoSize = true;
            this.NOTICE.BackColor = System.Drawing.Color.Transparent;
            this.NOTICE.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NOTICE.ForeColor = System.Drawing.Color.Red;
            this.NOTICE.Location = new System.Drawing.Point(120, 8);
            this.NOTICE.Name = "NOTICE";
            this.NOTICE.Size = new System.Drawing.Size(98, 19);
            this.NOTICE.TabIndex = 16;
            this.NOTICE.Text = "NO NOTICE";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.NOTICE);
            this.panel1.Location = new System.Drawing.Point(1001, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(333, 41);
            this.panel1.TabIndex = 17;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Transparent;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Controls.Add(this.smsPanel);
            this.panel2.Location = new System.Drawing.Point(12, 4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(292, 41);
            this.panel2.TabIndex = 17;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // smsPanel
            // 
            this.smsPanel.AutoSize = true;
            this.smsPanel.BackColor = System.Drawing.Color.Transparent;
            this.smsPanel.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.smsPanel.ForeColor = System.Drawing.Color.Red;
            this.smsPanel.Location = new System.Drawing.Point(93, 9);
            this.smsPanel.Name = "smsPanel";
            this.smsPanel.Size = new System.Drawing.Size(98, 19);
            this.smsPanel.TabIndex = 16;
            this.smsPanel.Text = "NO NOTICE";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(307, -15);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(78, 13);
            this.label5.TabIndex = 20;
            this.label5.Text = "Request Book:";
            // 
            // replyBox
            // 
            this.replyBox.AcceptsReturn = true;
            this.replyBox.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.replyBox.Location = new System.Drawing.Point(12, 49);
            this.replyBox.Multiline = true;
            this.replyBox.Name = "replyBox";
            this.replyBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.replyBox.Size = new System.Drawing.Size(292, 48);
            this.replyBox.TabIndex = 19;
            // 
            // replyButton
            // 
            this.replyButton.BackColor = System.Drawing.Color.Honeydew;
            this.replyButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.replyButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.replyButton.Location = new System.Drawing.Point(11, 100);
            this.replyButton.Name = "replyButton";
            this.replyButton.Size = new System.Drawing.Size(145, 29);
            this.replyButton.TabIndex = 18;
            this.replyButton.Text = "SEND REPLY";
            this.replyButton.UseVisualStyleBackColor = false;
            this.replyButton.Click += new System.EventHandler(this.replyButton_Click);
            // 
            // clearButton
            // 
            this.clearButton.BackColor = System.Drawing.Color.Honeydew;
            this.clearButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.clearButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clearButton.Location = new System.Drawing.Point(160, 100);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(145, 29);
            this.clearButton.TabIndex = 18;
            this.clearButton.Text = "CLEAR";
            this.clearButton.UseVisualStyleBackColor = false;
            this.clearButton.Click += new System.EventHandler(this.clearButton_Click);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // StudentIntroduction
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1347, 619);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.replyBox);
            this.Controls.Add(this.clearButton);
            this.Controls.Add(this.replyButton);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.borrowButton);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.allButton);
            this.Controls.Add(this.searchButton);
            this.Controls.Add(this.titleBox);
            this.Controls.Add(this.sectionComboBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.Name = "StudentIntroduction";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Seminar Library";
            this.Load += new System.EventHandler(this.StudentIntroduction_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button requestButton;
        private System.Windows.Forms.Button newCardButton;
        private System.Windows.Forms.Button libraryCardShowbutton;
        private System.Windows.Forms.Button updateButton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox sectionComboBox;
        private System.Windows.Forms.TextBox titleBox;
        private System.Windows.Forms.Button searchButton;
        private System.Windows.Forms.Button allButton;
        private System.Windows.Forms.Button borrowButton;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader title;
        private System.Windows.Forms.ColumnHeader author;
        private System.Windows.Forms.ColumnHeader popularity;
        private System.Windows.Forms.ColumnHeader Condition;
        private System.Windows.Forms.ColumnHeader deadline;
        private System.Windows.Forms.ColumnHeader book_id;
        private System.Windows.Forms.ColumnHeader quantity;
        private System.Windows.Forms.Button borrowedBooksButton;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox requestBox;
        private System.Windows.Forms.Button logOutButton;
        private System.Windows.Forms.Button seeSectionButton;
        private System.Windows.Forms.Label NOTICE;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label smsPanel;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox replyBox;
        private System.Windows.Forms.Button replyButton;
        private System.Windows.Forms.Button clearButton;
        private System.Windows.Forms.Timer timer1;
    }
}