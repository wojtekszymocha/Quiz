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
    public partial class AddQuestions : Form
    {
        public AddQuestions()
        {
            InitializeComponent();
        }

        private void AddQuestions_Load(object sender, EventArgs e)
        { 
            // TODO: Ten wiersz kodu wczytuje dane do tabeli 'quizDataSet.exams' . Możesz go przenieść lub usunąć.
            this.examsTableAdapter1.Fill(this.quiz_newDataSet.exams);
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            label8.Text = comboBox1.SelectedValue.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Questions q = new Questions();
            q.questions_title = textBox1.Text;
            q.questions_option_A = textBox2.Text;
            q.questions_option_B = textBox3.Text;
            q.questions_option_C = textBox4.Text;
            q.questions_option_D = textBox5.Text;
            q.questions_option_correct = textBox6.Text;
            q.questions_addeddate = System.DateTime.Now.ToShortDateString();
            q.questions_fk_admin = AdminLogin.fk_ad;
            q.questions_fk_exam = comboBox1.SelectedValue.ToString();

           
            IInsert_Questions ic = new Insert_Questions();
            string msg = ic.insert_srecord(q);
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            textBox5.Text = "";
            textBox6.Text = "";

            MessageBox.Show(msg);

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form2 f = new Form2();
            f.Show();
            this.Hide();

        }
    }
}
