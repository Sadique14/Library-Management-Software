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
    public partial class Update : Form
    {
        Database db;
        int ID;
        public Update(int ID)
        {
            InitializeComponent();
            db = new Database();
            this.ID = ID;
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void Update_Load(object sender, EventArgs e)
        {
            updateData ud = db.readUpdateData(ID);
            nameBox.Text = ud.name;
            termBox.Text = ud.term.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            nameBox.Clear();
            termBox.Clear();
            numberBox.Clear();
            typeBox.Clear();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void updateInfoButton_Click(object sender, EventArgs e)
        {
            if (db.updateStudentInformation(ID.ToString(), nameBox.Text, termBox.Text, numberBox.Text, typeBox.Text))
                MessageBox.Show("UPDATE SUCCESSFUL.");
            else
                MessageBox.Show("UPDATE FAILED.");
        }
    }
}
