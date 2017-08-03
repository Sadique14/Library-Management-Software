namespace Library_Management
{
    partial class Borrow_Information
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
            this.button1 = new System.Windows.Forms.Button();
            this.delayReturnButton = new System.Windows.Forms.Button();
            this.fineButton = new System.Windows.Forms.Button();
            this.backButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listView1
            // 
            this.listView1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.listView1.BackColor = System.Drawing.SystemColors.Info;
            this.listView1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.listView1.CheckBoxes = true;
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.book_id,
            this.title,
            this.author,
            this.popularity});
            this.listView1.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listView1.FullRowSelect = true;
            this.listView1.GridLines = true;
            this.listView1.HoverSelection = true;
            this.listView1.Location = new System.Drawing.Point(342, 30);
            this.listView1.MultiSelect = false;
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(875, 487);
            this.listView1.TabIndex = 16;
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
            this.title.Text = "TAKEN BOOKS";
            this.title.Width = 260;
            // 
            // author
            // 
            this.author.Text = "TAKEN DATE";
            this.author.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.author.Width = 250;
            // 
            // popularity
            // 
            this.popularity.Text = "RETURN DATE";
            this.popularity.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.popularity.Width = 100;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 28);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(314, 41);
            this.button1.TabIndex = 17;
            this.button1.Text = "BORROW INFORMATION";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // delayReturnButton
            // 
            this.delayReturnButton.Location = new System.Drawing.Point(12, 75);
            this.delayReturnButton.Name = "delayReturnButton";
            this.delayReturnButton.Size = new System.Drawing.Size(314, 41);
            this.delayReturnButton.TabIndex = 17;
            this.delayReturnButton.Text = "DELAYED RETURN LIST";
            this.delayReturnButton.UseVisualStyleBackColor = true;
            this.delayReturnButton.Click += new System.EventHandler(this.delayReturnButton_Click);
            // 
            // fineButton
            // 
            this.fineButton.Location = new System.Drawing.Point(12, 122);
            this.fineButton.Name = "fineButton";
            this.fineButton.Size = new System.Drawing.Size(314, 41);
            this.fineButton.TabIndex = 17;
            this.fineButton.Text = "FINE SELECTED STUDENT";
            this.fineButton.UseVisualStyleBackColor = true;
            this.fineButton.Click += new System.EventHandler(this.fineButton_Click);
            // 
            // backButton
            // 
            this.backButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.backButton.Location = new System.Drawing.Point(79, 285);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(154, 79);
            this.backButton.TabIndex = 17;
            this.backButton.Text = "BACK";
            this.backButton.UseVisualStyleBackColor = true;
            this.backButton.Click += new System.EventHandler(this.backButton_Click);
            // 
            // Borrow_Information
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(1229, 528);
            this.Controls.Add(this.backButton);
            this.Controls.Add(this.fineButton);
            this.Controls.Add(this.delayReturnButton);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.listView1);
            this.Name = "Borrow_Information";
            this.Text = "Borrow Information";
            this.Load += new System.EventHandler(this.Borrow_Information_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader book_id;
        private System.Windows.Forms.ColumnHeader title;
        private System.Windows.Forms.ColumnHeader author;
        private System.Windows.Forms.ColumnHeader popularity;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button delayReturnButton;
        private System.Windows.Forms.Button fineButton;
        private System.Windows.Forms.Button backButton;
    }
}