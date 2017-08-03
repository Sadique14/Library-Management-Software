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
    public partial class Introduction : Form
    {
        public Introduction()
        {
            InitializeComponent();
        }
        public Introduction(String name, String password)
        {
            /*this.name = name;
            this.password = password;
            db = new Database();
            x = 122;
            y = 6;*/
        }
        private void Introduction_Load(object sender, EventArgs e)
        {

        }

        private void newBookButton_Click(object sender, EventArgs e)
        {
            NewBook nb = new NewBook();
            nb.ShowDialog();
        }
    }
}
