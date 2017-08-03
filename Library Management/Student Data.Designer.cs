namespace Library_Management
{
    partial class Student_Data
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
            this.popularity = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.quantity = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label1 = new System.Windows.Forms.Label();
            this.sendNoticeBox = new System.Windows.Forms.TextBox();
            this.sendButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listView1
            // 
            this.listView1.BackColor = System.Drawing.SystemColors.Info;
            this.listView1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.listView1.CheckBoxes = true;
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.book_id,
            this.title,
            this.author,
            this.popularity,
            this.quantity});
            this.listView1.Dock = System.Windows.Forms.DockStyle.Top;
            this.listView1.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listView1.FullRowSelect = true;
            this.listView1.GridLines = true;
            this.listView1.HoverSelection = true;
            this.listView1.Location = new System.Drawing.Point(0, 0);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(875, 487);
            this.listView1.TabIndex = 15;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // book_id
            // 
            this.book_id.Text = "STUDENT ID";
            this.book_id.Width = 160;
            // 
            // title
            // 
            this.title.Text = "NAME";
            this.title.Width = 260;
            // 
            // author
            // 
            this.author.Text = "DISCIPLINE";
            this.author.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.author.Width = 250;
            // 
            // popularity
            // 
            this.popularity.Text = "YEAR";
            this.popularity.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.popularity.Width = 100;
            // 
            // quantity
            // 
            this.quantity.Text = "TERM";
            this.quantity.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.quantity.Width = 100;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(294, 492);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(249, 15);
            this.label1.TabIndex = 22;
            this.label1.Text = "SEND MESSAGE to SELECTED STUDENTS";
            // 
            // sendNoticeBox
            // 
            this.sendNoticeBox.AcceptsReturn = true;
            this.sendNoticeBox.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sendNoticeBox.Location = new System.Drawing.Point(261, 510);
            this.sendNoticeBox.Multiline = true;
            this.sendNoticeBox.Name = "sendNoticeBox";
            this.sendNoticeBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.sendNoticeBox.Size = new System.Drawing.Size(314, 48);
            this.sendNoticeBox.TabIndex = 21;
            // 
            // sendButton
            // 
            this.sendButton.Location = new System.Drawing.Point(261, 564);
            this.sendButton.Name = "sendButton";
            this.sendButton.Size = new System.Drawing.Size(314, 41);
            this.sendButton.TabIndex = 20;
            this.sendButton.Text = "SEND MESSAGE";
            this.sendButton.UseVisualStyleBackColor = true;
            this.sendButton.Click += new System.EventHandler(this.sendButton_Click);
            // 
            // Student_Data
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(875, 617);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.sendNoticeBox);
            this.Controls.Add(this.sendButton);
            this.Controls.Add(this.listView1);
            this.Name = "Student_Data";
            this.Text = "STUDENT DATA";
            this.Load += new System.EventHandler(this.Student_Data_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader book_id;
        private System.Windows.Forms.ColumnHeader title;
        private System.Windows.Forms.ColumnHeader author;
        private System.Windows.Forms.ColumnHeader popularity;
        private System.Windows.Forms.ColumnHeader quantity;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox sendNoticeBox;
        private System.Windows.Forms.Button sendButton;
    }
}