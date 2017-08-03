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
    public partial class StudentIntroduction : Form
    {
        string ID;
        string name;
        Database db;
        int x, y, x2, y2;
        int l1, l2;

        /*SqlConnection cn = new SqlConnection(@"Data Source=(localdb)\ProjectsV12;AttachDbFilename=F:\Visual Studio Projects\Library Management\Library Management\Library.mdf; Integrated Security=True");
        //Data Source=(LocalDB)\v11.0;AttachDbFilename=H:\2nd year, 2nd term\Visual Studio Projects\Hospital Management\Hospital Management\hospital.mdf;Integrated Security=True");
        SqlCommand cmd = new SqlCommand();
        SqlDataReader dr;*/
        /*SqlDataAdapter sda;
        SqlCommandBuilder scb;
        DataTable dt;*/
        public StudentIntroduction(string ID, string name)
        {
            InitializeComponent();
            this.ID = ID;
            this.name = name;
            db = new Database();
            x = 93;
            y = 9;
            x2 = 120;
            y2 = 8;
            l1 = 0;
            l2 = 0;
        }
        private void allButton_Click(object sender, EventArgs e)
        {
            /*sda = new SqlDataAdapter(@"select * from books",cn);
            dt = new DataTable();
            sda.Fill(dt);
            dataGridView1.DataSource = dt;*/
            //returnBookButton.Hide();
            sectionComboBox.Text = null;

            listView1.FullRowSelect = true;
            listView1.Items.Clear();

            Book[] b;
            b = db.readAllBooks();

            int i = 0;
            while (i < Book.k)
            {
                addToList(b[i].ID.ToString(), b[i].title.ToString(), b[i].author.ToString(), b[i].popularity.ToString(), b[i].quantity.ToString(), b[i].condition.ToString(), b[i].deadline.ToString());
                i++;
            }
        }

        private void StudentIntroduction_Load(object sender, EventArgs e)
        {
            NOTICE.Text = "NO NOTICE";
            smsPanel.Text = "WELCOME ";
            smsPanel.Text += name;
            smsPanel.Text += " -NO MESSAGE";
            requestBox.Text = null;
            //returnBookButton.Hide();
            string sms = db.readMessage(ID);
            //MessageBox.Show(sms);
            if (sms != null)
            {
                smsPanel.Text="";
                smsPanel.Text = sms;
                //NOTICE.Items.Add(d[i].speciality);
                //NOTICE.Items.Add("");
            }

            sectionComboBox.Items.Clear();
            sectionComboBox.Text = null;
            List<string> sections = db.readAllSections();
            for (int i = 0; i < sections.Count; i++)
            {
                sectionComboBox.Items.Add(sections[i]);
            }
            int flag = 0;
            if(db.checkFine(ID))
            {
                flag = 1;
                NOTICE.Text = "";
                NOTICE.Text = "You have been fined for not returning book timely, please check your borrowed book list.";
            }
            int x = db.checkRequest(ID);
            if (x == 1)
            {
                if (flag == 0)
                {
                    NOTICE.Text = "";
                    flag = 2;
                }
                NOTICE.Text += " YOUR LAST REQUEST WAS ACCEPTED";
            }
            else if(x==0)
            {
                if (flag == 0)
                    NOTICE.Text = "";
                NOTICE.Text += " YOUR LAST REQUEST WAS REJECTED";
            }
            l1 = smsPanel.Text.Length;
            l2 = NOTICE.Text.Length;
            timer1.Start();
        }
        private void addToList(string id, string title, string author, string po, string q, string c, string d)
        {
            string[] row = { id, title, author, po, q, c, d };
            ListViewItem item = new ListViewItem(row);
            listView1.Items.Add(item);
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void borrowButton_Click(object sender, EventArgs e)
        {
            int length = listView1.CheckedItems.Count;
            if (length > 3)
                MessageBox.Show("SORRY, YOU CAN NOT GET MORE THAN 3 BOOKS AT A TIME.");
            else if (length == 0)
                MessageBox.Show("PLEASE, CHECK AT LEAST A BOOK.");
            else
            {
                db.updateLibraryCard(ID, length);
                Takes[] t = new Takes[10];
                for (int i = 0; i < 10; i++)
                {
                    t[i] = new Takes();
                }
                //ListView.CheckedListViewItemCollection checkedItems = listView1.CheckedItems;
                //MessageBox.Show(listView1.CheckedItems[1].SubItems[1].Text);
                for (int i = 0; i < length; i++)
                {
                    t[i].book_ID = Convert.ToInt32(listView1.CheckedItems[i].SubItems[0].Text);
                    t[i].ID = Convert.ToInt32(ID);
                    t[i].date_taken = DateTime.Now.ToString("dd.MM.yy");
                    t[i].last_date = DateTime.Now.AddDays(db.getDeadlineOfBook(t[i].book_ID)).ToString("dd.MM.yy");
                }
                if (db.borrowBook(t, length))
                    MessageBox.Show("Borrowed Successful.");
                else
                    MessageBox.Show("You already have one of the selected books, Please, check again.");
            }
        }

        private void newCardButton_Click(object sender, EventArgs e)
        {
            if (db.checkCard(Convert.ToInt32(ID)))
            {

                MessageBox.Show("YOU ALREADY HAVE A CARD");
            }
            else
            {
                if (db.createNewCard(Convert.ToInt32(ID)))
                {
                    MessageBox.Show("NEW CARD CREATED SUCCESSFULY. TO SHOW YOUR CARD GO TO LIBRARY CARD SECTION");
                }
                else
                {
                    MessageBox.Show("UNEXPECTED ERROR, PLEASE, TRY LATER");
                }

            }
        }

        private void libraryCardShowButton_Click(object sender, EventArgs e)
        {
            if (db.checkCard(Convert.ToInt32(ID)))
            {
                showCards s = new showCards(Convert.ToInt32(ID));
                s.ShowDialog();
            }
            else
            {
                MessageBox.Show("You don't have any cards.", "Error...", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
                if (db.returnBook(ID, book_ID) && db.clearFine(ID, book_ID))
                    MessageBox.Show("RETURN Successful.");
                else
                    MessageBox.Show("You don't have one of the selected books, Please, check again.");
            }
            //returnBookButton.Hide();
        }

        private void borrowedBooksButton_Click(object sender, EventArgs e)
        {
            Borrowed_Book_List bbl = new Borrowed_Book_List(Convert.ToInt32(ID));
            bbl.ShowDialog();
        }

        private void sectionComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            //if(combo.Text=="admin")
            //adminForm f = new adminform();  f.showDialogue();
            listView1.FullRowSelect = true;
            listView1.Items.Clear();
            List<Book> b;
            b = db.readBooksFromSection(sectionComboBox.Text);
            int i = 0;
            while (i < b.Count())
            {
                addToList(b[i].ID, b[i].title, b[i].author, b[i].popularity.ToString(), b[i].quantity.ToString(), b[i].condition, b[i].deadline.ToString());
                i++;
            }
        }

        private void requestButton_Click(object sender, EventArgs e)
        {
            if (requestBox.Text.Length > 1)
            {
                if (db.sendRequest(Convert.ToInt32(ID), requestBox.Text))
                {
                    MessageBox.Show("REQUEST SENT");
                }
                else
                {
                    MessageBox.Show("FAILED TO SEND REQUEST");
                }
            }
            else
                MessageBox.Show("NOTHING TO SEND");
        }

        private void seeSectionButton_Click(object sender, EventArgs e)
        {
            string section = db.readAllSection();
            MessageBox.Show(section);
        }

        private void logOutButton_Click(object sender, EventArgs e)
        {
            this.Close();
           // LogIn l = new LogIn();
            //l.Show();
        }

        private void updateButton_Click(object sender, EventArgs e)
        {
            Update u = new Update(Convert.ToInt32(ID));
            u.ShowDialog();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void replyButton_Click(object sender, EventArgs e)
        {
            //smsPanel.Text = null;
            //requestBox.Text = null;
            //returnBookButton.Hide();
            //string sms = db.readMessage(Convert.ToInt32(ID));
            if (replyBox.Text.Length > 1)
            {
                if (db.sendReply(ID, replyBox.Text))
                {
                    smsPanel.Text = null;
                    MessageBox.Show("REPLY SENT.");
                    //smsPanel.Text = sms;
                    //NOTICE.Items.Add(d[i].speciality);
                    //NOTICE.Items.Add("");
                }
            }
            else
            {
                MessageBox.Show("NOTHING TO SEND");
            }
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            replyBox.Text = null;
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            listView1.FullRowSelect = true;
            listView1.Items.Clear();

            List<Book> b;
            b = db.searchBooks(titleBox.Text);

            int i = 0;
            while (i < b.Count)
            {
                addToList(b[i].ID.ToString(), b[i].title.ToString(), b[i].author.ToString(), b[i].popularity.ToString(), b[i].quantity.ToString(), b[i].condition.ToString(), b[i].deadline.ToString());
                i++;
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            x = x - 5;
            smsPanel.Location = new Point(x, y);
            if (x < -(l1*11))
                x = 292;

            x2 = x2 - 5;
            NOTICE.Location = new Point(x2, y2);
            if (x2 < -(l2*11))
                x2 = 333;
        }
    }
}
