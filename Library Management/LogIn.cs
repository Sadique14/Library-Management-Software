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
    public partial class LogIn : Form
    {
        SqlConnection cn = new SqlConnection(@"Data Source=(localdb)\ProjectsV12;AttachDbFilename=F:\Visual Studio Projects\Library Management\Library Management\Library.mdf; Integrated Security=True");
        //Data Source=(LocalDB)\v11.0;AttachDbFilename=H:\2nd year, 2nd term\Visual Studio Projects\Hospital Management\Hospital Management\hospital.mdf;Integrated Security=True");
        SqlCommand cmd = new SqlCommand();
        SqlDataReader dr;
        int x,y;
        public LogIn()
        {
            x = 109;
            y = 9;
            InitializeComponent();
        }
    
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            timer1.Start();
            //string fileName =
            //string path = Path.Combine(Environment.CurrentDirectory, fileName);
            cmd.Connection = cn;
            //cn.Open();
        }

        private void EnterButton_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Equals("123456") && textBox2.Text.Equals("Admin"))
            {
                textBox1.Text = null;
                textBox2.Text = null;
                LibIntroduction nb = new LibIntroduction();
                nb.ShowDialog();
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
                            StudentIntroduction intro = new StudentIntroduction(dr["ID"].ToString(), dr["name"].ToString());
                            //this.Hide();
                            textBox1.Text = null;
                            textBox2.Text = null;
                            intro.ShowDialog();
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
            Application.Exit();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = null;
            textBox2.Text = null;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            x = x - 5;
            label3.Location = new Point(x, y);
            if (x < -439)
                x = 631;
        }
    }
}
