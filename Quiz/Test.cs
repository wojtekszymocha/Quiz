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
    public partial class Test : Form
    {
        int i,score=0;
        string correct_option;

        public Test()
        {
            InitializeComponent();
        }

        returnclass rc = new returnclass();


       

        private void Test_Load_1(object sender, EventArgs e)
        {
            label7.Text = score.ToString();
            i = Convert.ToInt32(rc.scalarReturn("select min(questions_id) from questions"));
            label1.Text = rc.scalarReturn("select questions_title from questions where questions_id="+i);
            radioButton1.Text = rc.scalarReturn("select questions_option_A from questions where questions_id=" + i);
            radioButton2.Text = rc.scalarReturn("select questions_option_B from questions where questions_id=" + i);
            radioButton3.Text = rc.scalarReturn("select questions_option_C from questions where questions_id=" + i);
            radioButton4.Text = rc.scalarReturn("select questions_option_D from questions where questions_id=" + i);
            correct_option = rc.scalarReturn("select questions_option_correct from questions where questions_id=" + i);
        }
        string s,selected_value;
        private void button1_Click(object sender, EventArgs e)
        {
            if(radioButton1.Checked == true)
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

            s = rc.scalarReturn("select min(questions_id) from questions where questions_id>" + i);
            if (s.Equals(""))
            {
                MessageBox.Show("Quiz over");
                button1.Enabled = false;
            }
            else
            {
                i = Convert.ToInt32(s);
                label1.Text = rc.scalarReturn("select questions_title from questions where questions_id=" + i);
                radioButton1.Text = rc.scalarReturn("select questions_option_A from questions where questions_id=" + i);
                radioButton2.Text = rc.scalarReturn("select questions_option_B from questions where questions_id=" + i);
                radioButton3.Text = rc.scalarReturn("select questions_option_C from questions where questions_id=" + i);
                radioButton4.Text = rc.scalarReturn("select questions_option_D from questions where questions_id=" + i);
            }
            radiobtn();
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
