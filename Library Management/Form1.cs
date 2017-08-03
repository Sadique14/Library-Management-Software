using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.IO;

namespace Library_Management
{
    public partial class Form1 : Form
    {
        SqlConnection cn = new SqlConnection(@"Data Source=(localdb)\ProjectsV12;AttachDbFilename=F:\Visual Studio Projects\Library Management\Library Management\Library.mdf; Integrated Security=True");
        //Data Source=(LocalDB)\v11.0;AttachDbFilename=H:\2nd year, 2nd term\Visual Studio Projects\Hospital Management\Hospital Management\hospital.mdf;Integrated Security=True");
        SqlCommand cmd = new SqlCommand();
        SqlDataReader dr;
        public Form1()
        {
            InitializeComponent();
        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //string fileName =
            //string path = Path.Combine(Environment.CurrentDirectory, fileName);
            cmd.Connection = cn;
            //cn.Open();
        }

        private void EnterButton_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Equals("Admin") && textBox2.Text.Equals("123456"))
            {
                Introduction ie = new Introduction();
                ie.ShowDialog();
            }
            else
            {
                int flag = 0;
                try
                {
                    cn.Open();
                    cmd.CommandText = "select ID,name from student";
                    dr = cmd.ExecuteReader();
                    while (dr.Read())
                    {
                        if (textBox1.Text.Equals(dr["ID"].ToString()) && textBox2.Text.Equals(dr["name"].ToString()))
                        {
                            Introduction intro = new Introduction(dr["ID"].ToString(), dr["name"].ToString());
                            this.Hide();
                            intro.Show();
                            flag = 1;
                            break;
                        }
                    }
                    if (flag == 0)
                    {
                        MessageBox.Show("Wrong Password", "Error...", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                catch (Exception el)
                {
                    MessageBox.Show(el.Message);
                }
                finally
                {
                    cn.Close();
                }
            }
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            cn.Close();
            Form1 f = new Form1();
            f.Close();
        }
    }
}
