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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            AddQuestions a = new AddQuestions();
            a.Show();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            SetExam se = new SetExam();
            se.Show();
        }
    }
}
