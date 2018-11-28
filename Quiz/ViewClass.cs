using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Quiz
{
    class ViewClass
    {
        private string connstring = ConfigurationManager.ConnectionStrings["quizz"].ConnectionString;

        string querry;

        public ViewClass(string q)
        {
            this.querry = q;

        }

        public DataTable showrecord()
        {
            DataTable dt = new DataTable();
            SqlConnection connection = new SqlConnection(connstring);
            SqlCommand command = new SqlCommand(querry, connection);
            try
            {
                connection.Open();
                SqlDataReader dr = command.ExecuteReader();

                if (dr.HasRows)
                {
                    dt.Load(dr);
                }

            }
            catch(Exception)
            {
                MessageBox.Show("no records were found");
            }
            finally
            {
                connection.Close();
            }

            return dt;
        }
    }

}
