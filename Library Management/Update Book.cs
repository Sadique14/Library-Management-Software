using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entity;

namespace Library_Management
{
    public partial class Update_Book : Form
    {
        Book b;
        Database db;
        public Update_Book(Book b)
        {
            InitializeComponent();
            this.b = b;
            db = new Database();
        }

        private void Update_Book_Load(object sender, EventArgs e)
        {
            nameBox.Text = b.title;
            authorBox.Text = b.author;
            quantityBox.Text = b.quantity.ToString();
            conditionBox.Text = b.condition;
            deadlineBox.Text = b.deadline.ToString();
        }

        private void updateButton_Click(object sender, EventArgs e)
        {
            Book bo = new Book();
            bo.ID = b.ID;
            bo.title = nameBox.Text;
            bo.author = authorBox.Text;
            bo.quantity = Convert.ToInt32(quantityBox.Text);
            bo.condition = conditionBox.Text;
            bo.deadline = Convert.ToInt32(deadlineBox.Text);
            if (db.updateBook(bo))
                MessageBox.Show("UPDATE SUCCESSFUL.");
            else
                MessageBox.Show("UPDATE FAILED");
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
