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
    public partial class newStudent : Form
    {
        public newStudent()
        {
            InitializeComponent();
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            Student dt = new Student();
            Database db = new Database();
            dt.ID = idBox.Text;
            dt.name = nameBox.Text;
            dt.discipline = disciplineBox.Text;
            dt.year = Convert.ToInt32(yearComboBox.Text);
            dt.term = Convert.ToInt32(termComboBox.Text);
            dt.number = Convert.ToInt32(mobileBox.Text);
            dt.type = typeBox.Text;
            if (db.saveNewStudent(dt))
            {
                infoLabel.ForeColor = Color.Green;
                infoLabel.Text = "New Book Added.";
                for (int i = 0; i < 600; i++)
                    for (int j = 0; j < 1200; j++)
                    { }
                infoLabel.Text = null;
            }
            else
            {
                infoLabel.ForeColor = Color.Red;
                infoLabel.Text = "Please, fill all field correctly.";
                for (int i = 0; i < 600; i++)
                    for (int j = 0; j < 1200; j++)
                    { }
                infoLabel.Text = null;
            }
        }

        private void resetButton_Click(object sender, EventArgs e)
        {
            idBox.Clear();
            nameBox.Clear();
            disciplineBox.Clear();
            mobileBox.Clear();
            typeBox.Clear();
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
