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
    public partial class Ranking : Form
    {
        
        string exam_id;
        public Ranking(string exam_id)
        {
            InitializeComponent();
            this.exam_id = exam_id;
        }
        returnclass rc = new returnclass();

        private  void Ranking_Load(object sender, EventArgs e)
        {   
            string q = "select top 5 s.score,std.student_name from SCORE s join student_record std on std.student_id = s.student_fk_id order by score desc ";
            ViewClass viewClass = new ViewClass(q);
            dataGridView1.DataSource = viewClass.showrecord();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 f = new Form1();
            f.Show();
            this.Hide();
        }
    }
}
