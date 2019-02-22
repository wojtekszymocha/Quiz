using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Quiz
{
    public partial class AdminLogin : Form
    {
        public static string fk_ad;

        public AdminLogin()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {

            string user = textBox1.Text;
            string password = textBox2.Text;
            string userdb, passworddb;

            returnclass rc = new returnclass();
            userdb = rc.scalarReturn("select COUNT(admin_id) from admin_authorization where admin_user = '"+user+"'");


            if (userdb.Equals("0"))
            {
                MessageBox.Show("Invalid user name!");
            }
            else
            {
                passworddb = rc.scalarReturn("select admin_password from admin_authorization where admin_user = '"+user+"'");

                if (passworddb.Equals(password))
                {
                    fk_ad = rc.scalarReturn("select admin_id from admin_authorization where admin_user = '"+user+"'");

                    Form2 f = new Form2();
                    f.Show();
                    this.Hide();

                }
                else
                {
                    MessageBox.Show("Invalid Password!");
                }


            }
        }

        private void AdminLogin_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 f = new Form1();
            f.Show();
            this.Hide();
        }
    }
}
