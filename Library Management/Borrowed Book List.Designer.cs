namespace Library_Management
{
    partial class Borrowed_Book_List
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
            this.listView1 = new System.Windows.Forms.ListView();
            this.book_id = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.title = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.author = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.borrowedBooksButton = new System.Windows.Forms.Button();
            this.returnBookButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listView1
            // 
            this.listView1.CheckBoxes = true;
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.book_id,
            this.title,
            this.author,
            this.columnHeader1,
            this.columnHeader2});
            this.listView1.Dock = System.Windows.Forms.DockStyle.Top;
            this.listView1.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listView1.FullRowSelect = true;
            this.listView1.GridLines = true;
            this.listView1.HoverSelection = true;
            this.listView1.Location = new System.Drawing.Point(0, 0);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(996, 425);
            this.listView1.TabIndex = 15;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // book_id
            // 
            this.book_id.Text = "BOOK ID";
            this.book_id.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.book_id.Width = 100;
            // 
            // title
            // 
            this.title.Text = "TITLE OF THE BOOK";
            this.title.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.title.Width = 300;
            // 
            // author
            // 
            this.author.Text = "AUTHOR";
            this.author.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.author.Width = 350;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "DATE TAKEN";
            this.columnHeader1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader1.Width = 120;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "RETURN DATE";
            this.columnHeader2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader2.Width = 120;
            // 
            // borrowedBooksButton
            // 
            this.borrowedBooksButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.borrowedBooksButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.borrowedBooksButton.Location = new System.Drawing.Point(53, 441);
            this.borrowedBooksButton.Name = "borrowedBooksButton";
            this.borrowedBooksButton.Size = new System.Drawing.Size(175, 38);
            this.borrowedBooksButton.TabIndex = 17;
            this.borrowedBooksButton.Text = "REFRESH";
            this.borrowedBooksButton.UseVisualStyleBackColor = true;
            this.borrowedBooksButton.Click += new System.EventHandler(this.borrowedBooksButton_Click);
            // 
            // returnBookButton
            // 
            this.returnBookButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.returnBookButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.returnBookButton.Location = new System.Drawing.Point(234, 442);
            this.returnBookButton.Name = "returnBookButton";
            this.returnBookButton.Size = new System.Drawing.Size(208, 37);
            this.returnBookButton.TabIndex = 16;
            this.returnBookButton.Text = "RETURN SELECTED BOOKS";
            this.returnBookButton.UseVisualStyleBackColor = true;
            this.returnBookButton.Click += new System.EventHandler(this.returnBookButton_Click);
            // 
            // Borrowed_Book_List
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(996, 571);
            this.Controls.Add(this.borrowedBooksButton);
            this.Controls.Add(this.returnBookButton);
            this.Controls.Add(this.listView1);
            this.Name = "Borrowed_Book_List";
            this.Text = "BORROWED BOOKS LIST";
            this.Load += new System.EventHandler(this.Borrowed_Book_List_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader book_id;
        private System.Windows.Forms.ColumnHeader title;
        private System.Windows.Forms.ColumnHeader author;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.Button borrowedBooksButton;
        private System.Windows.Forms.Button returnBookButton;
    }
}