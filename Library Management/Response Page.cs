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
    public partial class Response_Page : Form
    {
        Database db;
        public Response_Page()
        {
            db = new Database();
            InitializeComponent();
        }

        private void acceptButton_Click(object sender, EventArgs e)
        {

        }
        private void addToList(string id, string title)
        {
            string[] row = { id, title };
            ListViewItem item = new ListViewItem(row);
            listView1.Items.Add(item);
        }
        private void Response_Page_Load(object sender, EventArgs e)
        {
            listView1.FullRowSelect = true;
            listView1.Items.Clear();

            List<Request> b;
            b = db.readAllResponse();
            int i = 0;
            while (i < b.Count)
            {
                addToList(b[i].ID, b[i].req);
                i++;
            }
        }
    }
}
