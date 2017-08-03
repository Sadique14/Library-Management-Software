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
    public partial class LibIntroduction : Form
    {
        Database db;
        public LibIntroduction()
        {
            InitializeComponent();
            db = new Database();
        }

        private void Introduction_Load(object sender, EventArgs e)
        {
            sectionComboBox.Items.Clear();
            sectionComboBox.Text = null;
            List<string> sections = db.readAllSections();
            for (int i = 0; i < sections.Count; i++)
            {
                sectionComboBox.Items.Add(sections[i]);
            }
        }

        private void newBookButton_Click(object sender, EventArgs e)
        {
            NewBookEntry nb = new NewBookEntry();
            nb.ShowDialog();
        }
        private void newStudentbutton_Click_1(object sender, EventArgs e)
        {
            newStudent ns = new newStudent();
            ns.ShowDialog();
        }

        private void ItemManagementbutton_Click(object sender, EventArgs e)
        {
            Book bl = null;
            int length = listView2.CheckedItems.Count;
            if (length > 1)
                MessageBox.Show("SORRY, YOU CAN NOT EDIT MORE THAN 1 BOOK AT A TIME.");
            else if (length == 0)
                MessageBox.Show("PLEASE, CHECK A BOOK.");
            else
            {
                bl = new Book();
                bl.ID = listView2.CheckedItems[0].SubItems[0].Text;
                bl.title = listView2.CheckedItems[0].SubItems[1].Text;
                bl.author = listView2.CheckedItems[0].SubItems[2].Text;
                bl.popularity = Convert.ToInt32(listView2.CheckedItems[0].SubItems[3].Text);
                bl.quantity = Convert.ToInt32(listView2.CheckedItems[0].SubItems[4].Text);
                bl.condition = listView2.CheckedItems[0].SubItems[5].Text;
                bl.deadline = Convert.ToInt32(listView2.CheckedItems[0].SubItems[6].Text);
                Update_Book ub = new Update_Book(bl);
                ub.ShowDialog();
            }
        }
    private void addToList(string id, string title, string author, string po, string q, string c, string d)
    {
        string[] row = { id, title, author, po, q, c, d };
        ListViewItem item = new ListViewItem(row);
        listView2.Items.Add(item);
    }
    private void allButton_Click(object sender, EventArgs e)
    {
        sectionComboBox.Text = null;

        listView2.FullRowSelect = true;
        listView2.Items.Clear();

        Book[] b;
        b = db.readAllBooks();

        int i = 0;
        while (i < Book.k)
        {
            addToList(b[i].ID.ToString(), b[i].title.ToString(), b[i].author.ToString(), b[i].popularity.ToString(), b[i].quantity.ToString(), b[i].condition.ToString(), b[i].deadline.ToString());
            i++;
        }
    }

        private void sectionComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (sectionComboBox.Text.Length > 2)
            {
                //listView2.FullRowSelect = true;
                listView2.Items.Clear();
                List<Book> b;
                b = db.readBooksFromSection(sectionComboBox.Text);
                int i = 0;
                while (i < b.Count())
                {
                    addToList(b[i].ID, b[i].title, b[i].author, b[i].popularity.ToString(), b[i].quantity.ToString(), b[i].condition, b[i].deadline.ToString());
                    i++;
                }
            }
        }

        private void newYearButton_Click(object sender, EventArgs e)
        {
            if(db.increaseOneYear())
            {
                MessageBox.Show("NEW YEAR STARTED.");
            }
            else
            {
                MessageBox.Show("FAILED TO START NEW YEAR.");
            }
        }

        private void studentInformationButton_Click(object sender, EventArgs e)
        {
            Student_Data sd = new Student_Data();
            sd.ShowDialog();

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void borrowedBooksButton_Click(object sender, EventArgs e)
        {
            Borrow_Information bi = new Borrow_Information();
            bi.ShowDialog();
        }

        private void seeRequestButton_Click(object sender, EventArgs e)
        {
            Request_Table rt = new Request_Table();
            rt.ShowDialog();
        }

        private void responseButton_Click(object sender, EventArgs e)
        {
            Response_Page rp = new Response_Page();
            rp.ShowDialog();
        }
    }
}
