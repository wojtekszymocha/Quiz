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

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void AddQuestions_Load(object sender, EventArgs e)
        {
            // TODO: Ten wiersz kodu wczytuje dane do tabeli 'quizDataSet.exams' . Możesz go przenieść lub usunąć.
        

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

            InsertClasses ic = new InsertClasses();
            string msg = ic.insert_srecord(q);
            MessageBox.Show(msg);

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }
    }
}
