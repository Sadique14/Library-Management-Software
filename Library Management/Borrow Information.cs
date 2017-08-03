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
    public partial class Borrow_Information : Form
    {
        Database db;
        public Borrow_Information()
        {
            InitializeComponent();
            db = new Database();
        }
        private void addToList(string id, string title, string author, string po)
        {
            string[] row = { id, title, author, po };
            ListViewItem item = new ListViewItem(row);
            listView1.Items.Add(item);
        }
        private void Borrow_Information_Load(object sender, EventArgs e)
        {
            listView1.FullRowSelect = true;
            listView1.Items.Clear();

            List<info> b;
            b = db.readInfo();
            int i = 0;
            while (i < b.Count)
            {
                addToList(b[i].ID.ToString(), b[i].book_ID.ToString(), b[i].date_taken.ToString(), b[i].return_date.ToString());
                i++;
            }
        }

        private void delayReturnButton_Click(object sender, EventArgs e)
        {
            listView1.FullRowSelect = true;
            listView1.Items.Clear();

            List<info> b;
            b = db.readDelayInfo();
            int i = 0;
            while (i < b.Count)
            {
                addToList(b[i].ID.ToString(), b[i].book_ID.ToString(), b[i].date_taken.ToString(), b[i].return_date.ToString());
                i++;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            listView1.FullRowSelect = true;
            listView1.Items.Clear();

            List<info> b;
            b = db.readInfo();
            int i = 0;
            while (i < b.Count)
            {
                addToList(b[i].ID.ToString(), b[i].book_ID.ToString(), b[i].date_taken.ToString(), b[i].return_date.ToString());
                i++;
            }
        }

        private void fineButton_Click(object sender, EventArgs e)
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
                    if (db.fineStudent(listView1.CheckedItems[i].SubItems[1].Text, listView1.CheckedItems[i].SubItems[0].Text))
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
                    MessageBox.Show("FINE SUCCESSFUL.");
            }
        }

        private void sendNotice_Click(object sender, EventArgs e)
        {
            
            /*DateTime date1 = DateTime.Now;
            DateTime date2 = DateTime.Now;
            int result = DateTime.Compare(date1, date2);
            MessageBox.Show(result.ToString());*/
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        /*private void fineButton_Click(object sender, EventArgs e)
          {
              int length = listView1.CheckedItems.Count;
              if (length > 3)
                  MessageBox.Show("SORRY, YOU CAN NOT GET MORE THAN 3 BOOKS AT A TIME.");
              else if (length == 0)
                  MessageBox.Show("PLEASE, CHECK AT LEAST A BOOK.");
              else
              {
                  if(db.fineStudent(Convert.ToInt32(listView1.CheckedItems[0].SubItems[0].Text), Convert.ToInt32(listView1.CheckedItems[0].SubItems[1].Text)))
                  {
                      MessageBox.Show("FINE SUCCESSFUL.");
                  }
                  else
                  {
                      MessageBox.Show("Failed");
                  }
              }
          }*/
    }
}
