namespace Library_Management
{
    partial class Introduction
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
            this.newBookButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // newBookButton
            // 
            this.newBookButton.Location = new System.Drawing.Point(12, 29);
            this.newBookButton.Name = "newBookButton";
            this.newBookButton.Size = new System.Drawing.Size(116, 42);
            this.newBookButton.TabIndex = 0;
            this.newBookButton.Text = "New Book Entry";
            this.newBookButton.UseVisualStyleBackColor = true;
            this.newBookButton.Click += new System.EventHandler(this.newBookButton_Click);
            // 
            // Introduction
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(690, 351);
            this.Controls.Add(this.newBookButton);
            this.Name = "Introduction";
            this.Text = "Intro";
            this.Load += new System.EventHandler(this.Introduction_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button newBookButton;
    }
}