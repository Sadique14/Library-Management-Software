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
    public partial class showCards : Form
    {
        int ID;
        Database db;
       
        public showCards(int ID)
        {
            InitializeComponent();
            this.ID = ID;
            db = new Database();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void addBookButton_Click(object sender, EventArgs e)
        {
            
        }
        int k;
        private void showCards_Load(object sender, EventArgs e)
        {
            try
            {
                //MessageBox.Show("n");
                LibraryCard lc = db.showCard(ID);
                //MessageBox.Show("m");
                //lc = db.showCard(ID);
                idLabel.Text = lc.ID.ToString();
                cardLabel.Text = lc.cardNumber.ToString();
                issueDateLabel.Text = lc.issueDate;
                deadLineLabel.Text = lc.deadline;
                numberOfBooksLabel.Text = lc.numberOfBook.ToString();
                //if (LibraryCard.k > 1)
                k = LibraryCard.k - 1;
                //else
                //  k = 10;
            }
            catch(Exception el)
            {
               
                this.Close();
            }
        }

        private void cardsButton_Click(object sender, EventArgs e)
        {
            LibraryCard[] lc;
            lc=db.showAllCards(ID);
            idLabel.Text = lc[k].ID.ToString();
            cardLabel.Text = lc[k].cardNumber.ToString();
            issueDateLabel.Text = lc[k].issueDate;
            deadLineLabel.Text = lc[k].deadline;
            numberOfBooksLabel.Text = lc[k].numberOfBook.ToString();
            if (k == 0)
                k = LibraryCard.k-1;
            else
                k = k - 1;
        }
    }
}
