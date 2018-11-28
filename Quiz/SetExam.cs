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
            // TODO: Ten wiersz kodu wczytuje dane do tabeli 'quizDataSet2.student_record' . Możesz go przenieść lub usunąć.
            this.student_recordTableAdapter1.Fill(this.quizDataSet2.student_record);
          
            string q = "select * from student_record";
            ViewClass viewClass = new ViewClass(q);
            dataGridView1.DataSource = viewClass.showrecord();

            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string q = "select * from student_record where student_batchcode='"+comboBox1.SelectedValue.ToString()+"'";
            ViewClass viewClass = new ViewClass(q);
            dataGridView1.DataSource = viewClass.showrecord();
        }
    }
}
