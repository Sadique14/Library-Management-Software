using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Library_Management
{
    public partial class NewBookEntry : Form
    {
       
        public NewBookEntry()
        {
            InitializeComponent();
        }
        protected override void OnKeyPress(KeyPressEventArgs e)
        {
            if (e.KeyChar == '\r')
            {
                e.Handled = true;
                SendKeys.Send("{TAB}");
            }

        }
        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            Book dt = new Book();
            Database db = new Database();
            dt.ID = idBox.Text;
            dt.title = titleBox.Text;
            dt.author = authorBox.Text;
            dt.quantity = Convert.ToInt32(quantityBox.Text);
            dt.condition = conditionBox.Text;
            dt.deadline = Convert.ToInt32(deadlineBox.Text);
            dt.section = sectionComboBox.Text;
            dt.Arrivaldate = dateTimePicker1.Text;
            if (db.saveNewBook(dt))
            {
                infoLabel.ForeColor = Color.Green;
                infoLabel.Text = "New Book Added.";
            }
            else
            {
                infoLabel.ForeColor = Color.Red;
                infoLabel.Text = "Please, fill all field correctly.";
            }
        }

        private void NewBook_Load(object sender, EventArgs e)
        {

        }

        private void addSection_Click(object sender, EventArgs e)
        {
            Database db = new Database();
            if(db.saveNewSection(sectionBox.Text, shelfBox.Text))
            {
                infoLabel2.ForeColor = Color.Green;
                infoLabel2.Text = "New Section Added.";
            }
            else
            {
                infoLabel2.ForeColor = Color.Red;
                infoLabel2.Text = "Please, fill all field correctly.";
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
