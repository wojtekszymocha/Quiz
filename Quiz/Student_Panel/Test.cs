using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Quiz
{
    public partial class Test : Form
    {
        public static int score = 0;
        public string student_id;
        public string exam_id;
        
        int i;
        int k;
        int j;
        string correct_option;

        returnclass rc = new returnclass();

        public Test(string student_id, string exam_id)
        {
            score = 0;
            InitializeComponent();
            this.student_id = student_id;
            this.exam_id = exam_id;
            j = Convert.ToInt32(rc.scalarReturn("select count(questions_id) from questions where  questions_fk_exam =" + StudentLogin.exam_id));
        }



        private   void Test_Load_1(object sender, EventArgs e)
        {
             label2.Text = rc.scalarReturn("select exam_name  from exams where exam_id="+StudentLogin.exam_id);              
             label7.Text = score.ToString();
             i = Convert.ToInt32(rc.scalarReturn("select min(questions_id) from questions where questions_fk_exam =" + StudentLogin.exam_id));
             label1.Text = rc.scalarReturn("select questions_title from questions where questions_id=" + i + "and questions_fk_exam = " + StudentLogin.exam_id);
             radioButton1.Text = rc.scalarReturn("select questions_option_A from questions where questions_id=" + i + "and questions_fk_exam =" + StudentLogin.exam_id);
             radioButton2.Text = rc.scalarReturn("select questions_option_B from questions where questions_id=" + i + "and questions_fk_exam =" + StudentLogin.exam_id);
             radioButton3.Text = rc.scalarReturn("select questions_option_C from questions where questions_id=" + i + "and questions_fk_exam =" + StudentLogin.exam_id);
             radioButton4.Text = rc.scalarReturn("select questions_option_D from questions where questions_id=" + i+ "and questions_fk_exam =" + StudentLogin.exam_id);
             correct_option = rc.scalarReturn("select questions_option_correct from questions where questions_id=" + i + "and questions_fk_exam =" + StudentLogin.exam_id);
        }
        string s,selected_value;
        private void button1_Click(object sender, EventArgs e)
        {
          
            if (radioButton1.Checked == true)
            {
                selected_value = radioButton1.Text;
            }
            else if(radioButton2.Checked == true)
            {
                selected_value = radioButton2.Text;
            }
            else if (radioButton3.Checked == true)
            {
                selected_value = radioButton3.Text;
            }
            else if (radioButton4.Checked == true)
            {
                selected_value = radioButton4.Text;
            }
            else
            {
                MessageBox.Show("Please select one option");
            }
            
            if(selected_value.Equals(correct_option))
            {
                score++;
                label7.Text = score.ToString();
            }

            s = rc.scalarReturn("select min(questions_id) from questions where questions_id>" + i+ "and questions_fk_exam =" + StudentLogin.exam_id);
            if (s.Equals(""))
            {
                MessageBox.Show("Quiz over");
                button1.Enabled = false;
                this.Enabled = false;
            }
            else
            {
                i = Convert.ToInt32(s);
                label2.Text = rc.scalarReturn("select exam_name  from exams where exam_id=" + StudentLogin.exam_id);
                label1.Text = rc.scalarReturn("select questions_title from questions where questions_id=" + i + " and questions_fk_exam =" + StudentLogin.exam_id);
                radioButton1.Text = rc.scalarReturn("select questions_option_A from questions where questions_id=" + i + "and questions_fk_exam =" + StudentLogin.exam_id);
                radioButton2.Text = rc.scalarReturn("select questions_option_B from questions where questions_id=" + i + "and questions_fk_exam =" + StudentLogin.exam_id);
                radioButton3.Text = rc.scalarReturn("select questions_option_C from questions where questions_id=" + i + "and questions_fk_exam =" + StudentLogin.exam_id);
                radioButton4.Text = rc.scalarReturn("select questions_option_D from questions where questions_id=" + i + "and questions_fk_exam =" + StudentLogin.exam_id);
                correct_option = rc.scalarReturn("select questions_option_correct from questions where questions_id=" + i + "and questions_fk_exam =" + StudentLogin.exam_id);
            }
            radiobtn();
            string lastquestion = rc.scalarReturn("select max(questions_id) from questions where questions_fk_exam = " + StudentLogin.exam_id);
            if(lastquestion.Equals(i.ToString()))
            {
                int sco = score;
                int student = Convert.ToInt32(student_id);
                int exam = Convert.ToInt32(exam_id);
                float per = (float)score/j;             
                IInsert_Score iC = new Insert_Score();
                iC.insert_Score(sco, student, exam, per);                
                button1.Enabled = false;
                this.Enabled = false;
                messageform mf = new messageform(exam_id);
                mf.Show();
                this.Hide();
            }
        }

       

        public void radiobtn()
        {
            radioButton1.Checked = false;
            radioButton2.Checked = false;
            radioButton3.Checked = false;
            radioButton4.Checked = false;
        }
    }
}
