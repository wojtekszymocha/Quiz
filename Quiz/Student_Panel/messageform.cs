using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace Quiz
{
    public partial class messageform : Form
    {
        string exam_id;

        public messageform(string exam_id)
        {
            InitializeComponent();
            this.exam_id = exam_id;
        }

        private  void messageform_Load(object sender, EventArgs e)
        {
            label3.Text = Test.score.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Ranking ranking = new Ranking(exam_id);
            ranking.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form1 f = new Form1();
            f.Show();
            this.Hide();
        }
    }
}
