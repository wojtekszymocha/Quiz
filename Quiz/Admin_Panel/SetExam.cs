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
    public partial class SetExam : Form
    {
        public SetExam()
        {
            InitializeComponent();
        }

        private void SetExam_Load(object sender, EventArgs e)
        {
            string q = "select * from student_record";
            ViewClass viewClass = new ViewClass(q);
            dataGridView1.DataSource = viewClass.showrecord();

            SqlDataAdapter dadpter = new SqlDataAdapter("select DISTINCT student_batchcode from student_record", "Data Source=LAPTOP-EBI4JBJ3\\SQLEXPRESS;Initial Catalog=Quiz_new;Integrated Security=True");
            DataSet dset = new DataSet();
            dadpter.Fill(dset);
            comboBox1.DataSource = dset.Tables[0];
            comboBox1.DisplayMember = "student_batchcode";
            comboBox1.ValueMember = "student_batchcode";

            SqlDataAdapter dadpter2 = new SqlDataAdapter("select *from exams", "Data Source=LAPTOP-EBI4JBJ3\\SQLEXPRESS;Initial Catalog=Quiz_new;Integrated Security=True");
            DataSet dset2 = new DataSet();
            dadpter2.Fill(dset2);
            comboBox2.DataSource = dset2.Tables[0];
            comboBox2.DisplayMember = "exam_name";
            comboBox2.ValueMember = "exam_id";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string q = "select *from student_record where student_id not in (select student_id_fk from set_exam) and student_batchcode='" + comboBox1.SelectedValue.ToString()+"'";
            ViewClass viewClass = new ViewClass(q);
            dataGridView1.DataSource = viewClass.showrecord();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
            IInsert_SetExam ic = new Insert_SetExam();
            ic.insert_SetExam(System.DateTime.Now.ToShortDateString(), textBox1.Text, comboBox2.SelectedValue.ToString());
            string q = "select * from set_exam";
            ViewClass viewClass = new ViewClass(q);
            dataGridView2.DataSource = viewClass.showrecord();

            q = "select *from student_record where student_id not in (select student_id_fk from set_exam) and student_batchcode='" + comboBox1.SelectedValue.ToString() + "'";
            ViewClass viewClass2 = new ViewClass(q);
            dataGridView1.DataSource = viewClass2.showrecord();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form2 f = new Form2();
            f.Show();
            this.Hide();
        }
    }
}
