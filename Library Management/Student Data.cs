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
    public partial class Student_Data : Form
    {
        Database db;
        public Student_Data()
        {
            InitializeComponent();
            db = new Database();
        //    this.s = s;
        }
        private void addToList(string id, string title, string author, string po, string q)
        {
            string[] row = { id, title, author, po,q };
            ListViewItem item = new ListViewItem(row);
            listView1.Items.Add(item);
        }
        private void Student_Data_Load(object sender, EventArgs e)
        {
            listView1.FullRowSelect = true;
            listView1.Items.Clear();

            List<Student> b;
            b = db.readAllStudents();
            int i = 0;
            while (i < b.Count)
            {
                addToList(b[i].ID.ToString(), b[i].name.ToString(), b[i].discipline.ToString(), b[i].year.ToString(), b[i].term.ToString());
                i++;
            }
        }

        private void sendButton_Click(object sender, EventArgs e)
        {
            int k = 0;
            int length = listView1.CheckedItems.Count;
            //if (length > 3)
            // MessageBox.Show("SORRY, YOU CAN NOT GET MORE THAN 3 BOOKS AT A TIME.");
            if (length == 0)
                MessageBox.Show("PLEASE, CHECK AT LEAST A STUDENT.");
            if(sendNoticeBox.Text.Length>1) 
            {
                for (int i = 0; i < length; i++)
                {
                    if (db.sendMessageToStudent(listView1.CheckedItems[i].SubItems[0].Text, sendNoticeBox.Text))
                    {
                        //MessageBox.Show("FINE SUCCESSFUL.");
                        k++;
                    }
                    else
                    {
                        MessageBox.Show("Failed");
                    }
                }
                if (k == length)
                    MessageBox.Show("NOTICE SENT.");
            }
            else
            {
                MessageBox.Show("NOTHING TO SEND.");
            }
        }
    }
}
