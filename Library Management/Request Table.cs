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
    public partial class Request_Table : Form
    {
        Database db;
        public Request_Table()
        {
            db = new Database();
            InitializeComponent();
        }
        private void addToList(string id, string title)
        {
            string[] row = { id, title};
            ListViewItem item = new ListViewItem(row);
            listView1.Items.Add(item);
        }
        private void Request_Table_Load(object sender, EventArgs e)
        {
            listView1.FullRowSelect = true;
            listView1.Items.Clear();

            List<Request> b;
            b = db.readAllRequests();
            int i = 0;
            while (i < b.Count)
            {
                addToList(b[i].ID, b[i].req);
                i++;
            }
        }

        private void acceptButton_Click(object sender, EventArgs e)
        {
             int k = 0;
            int length = listView1.CheckedItems.Count;
            //if (length > 3)
            // MessageBox.Show("SORRY, YOU CAN NOT GET MORE THAN 3 BOOKS AT A TIME.");
            if (length == 0)
                MessageBox.Show("PLEASE, CHECK AT LEAST A STUDENT.");
            else
            {
                for (int i = 0; i < length; i++)
                {
                    if (db.sendAcceptToStudent(listView1.CheckedItems[i].SubItems[0].Text))
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
                    MessageBox.Show("NOTICE SENt.");
                else
                {
                    MessageBox.Show("ERROR.");
                }
            }
        }

        private void rejectButton_Click(object sender, EventArgs e)
        {
            int k = 0;
            int length = listView1.CheckedItems.Count;
            //if (length > 3)
            // MessageBox.Show("SORRY, YOU CAN NOT GET MORE THAN 3 BOOKS AT A TIME.");
            if (length == 0)
                MessageBox.Show("PLEASE, CHECK AT LEAST A STUDENT.");
            else
            {
                for (int i = 0; i < length; i++)
                {
                    if (db.sendRejectToStudent(listView1.CheckedItems[i].SubItems[0].Text))
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
                else
                {
                    MessageBox.Show("ERROR.");
                }
            }
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
