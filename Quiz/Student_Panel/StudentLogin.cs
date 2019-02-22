using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Quiz
{
    public partial class StudentLogin : Form
    {
        public static string exam_id;
        public static string students_id;
        public static int exam_id_int;
        

        public StudentLogin()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string user = textBox1.Text;
            string password = textBox2.Text;
            string userdb, passworddb;

  

            returnclass rc = new returnclass();
            userdb = rc.scalarReturn("select count(student_id) from student_record where student_id='" + textBox1.Text + "'");
            students_id = textBox1.Text;
            if (userdb.Equals("0"))
            {
                MessageBox.Show("Invalid user name!");
            }
            else
            {
                passworddb = rc.scalarReturn("select student_password from student_record where student_id= '" + user + "'");

                if (passworddb.Equals(password))
                {
                    string val = rc.scalarReturn("select count(student_id) from student_record where student_id=(select student_id_fk from set_exam where student_id_fk="+textBox1.Text+" and exam_id_fk="+comboBox1.SelectedValue.ToString()+")");

                    if (val.Equals("0"))
                    {
                        MessageBox.Show("No such set exam!");
                    }
                    else
                    {
                        exam_id = comboBox1.SelectedValue.ToString();
                        students_id = textBox1.Text.ToString();
                        Test t = new Test(students_id,exam_id);
                            t.Show();
                        this.Hide();
                    }
                }
                else
                {
                    MessageBox.Show("Invalid Password!");
                }
            }
        }

        private void StudentLogin_Load(object sender, EventArgs e)
        {
            SqlDataAdapter dadpter2 = new SqlDataAdapter("select *from exams", "Data Source=LAPTOP-EBI4JBJ3\\SQLEXPRESS;Initial Catalog=Quiz_new;Integrated Security=True");
            DataSet dset2 = new DataSet();
            dadpter2.Fill(dset2);
            comboBox1.DataSource = dset2.Tables[0];
            comboBox1.DisplayMember = "exam_name";
            comboBox1.ValueMember = "exam_id";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 f = new Form1();
            f.Show();
            this.Hide();
        }
    }
}
