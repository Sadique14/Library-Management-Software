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
    public partial class Borrowed_Book_List : Form
    {
        Database db;
        int ID;
        public Borrowed_Book_List(int ID)
        {
            this.ID = ID;
            db = new Database();
            InitializeComponent();
        }
        private void addToList(string id, string title, string author, string po, string q)
        {
            string[] row = { id, title, author, po, q};
            ListViewItem item = new ListViewItem(row);
            listView1.Items.Add(item);
        }
        private void borrowedBooksButton_Click(object sender, EventArgs e)
        {
            if (db.checkBorrowedBooks(ID))
            {
                listView1.FullRowSelect = true;
                listView1.Items.Clear();

                List<BorrowedList> b;
                b = db.readBorrowedBooks(Convert.ToInt32(ID));
                int i = 0;
                while (i < b.Count)
                {
                    addToList(b[i].book_ID.ToString(), b[i].title.ToString(), b[i].author.ToString(), b[i].takenDate.ToString(), b[i].returnDate.ToString());
                    i++;
                }
                //returnBookButton.Show();
            }
            else
            {
                MessageBox.Show("YOU CURRENTLY DON'T HAVE ANY BORROWED BOOKS.");
            }
        }

        private void returnBookButton_Click(object sender, EventArgs e)
        {
            int length = listView1.CheckedItems.Count;
            //if (length > 3)
            //  MessageBox.Show("SORRY, YOU CAN NOT GET MORE THAN 3 BOOKS AT A TIME.");
            if (length == 0)
                MessageBox.Show("PLEASE, CHECK AT LEAST A BOOK.");
            else
            {
                List<int> book_ID = new List<int>();
                //ListView.CheckedListViewItemCollection checkedItems = listView1.CheckedItems;
                //MessageBox.Show(listView1.CheckedItems[1].SubItems[1].Text);
                for (int i = 0; i < length; i++)
                {
                    book_ID.Add(Convert.ToInt32(listView1.CheckedItems[i].SubItems[0].Text));
                }
                if (db.returnBook(ID.ToString(), book_ID) && db.clearFine(ID.ToString(), book_ID))
                    MessageBox.Show("RETURN Successful.");
                else
                    MessageBox.Show("You don't have one of the selected books, Please, check again.");
            }
            //returnBookButton.Hide();
        }

        private void Borrowed_Book_List_Load(object sender, EventArgs e)
        {
            if (db.checkBorrowedBooks(ID))
            {
                listView1.FullRowSelect = true;
                listView1.Items.Clear();

                List<BorrowedList> b;
                b = db.readBorrowedBooks(Convert.ToInt32(ID));
                int i = 0;
                while (i < b.Count)
                {
                    addToList(b[i].book_ID.ToString(), b[i].title.ToString(), b[i].author.ToString(), b[i].takenDate.ToString(), b[i].returnDate.ToString());
                    i++;
                }
                //returnBookButton.Show();
            }
            else
            {
                MessageBox.Show("YOU CURRENTLY DON'T HAVE ANY BORROWED BOOKS.");
            }
        }
    }
}
