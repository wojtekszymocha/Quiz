using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

namespace Quiz
{
    public class returnclass
    {
        private string connstring = ConfigurationManager.ConnectionStrings["quizz"].ConnectionString;

        public string scalarReturn(string q)
        {
            SqlConnection connection = new SqlConnection(connstring);
            connection.Open();
            string s;
            try
            {
                SqlCommand cmd = new SqlCommand(q, connection);

                s = cmd.ExecuteScalar().ToString();
            }
            catch (Exception)
            {

                s = " ";
            }
            
            connection.Close();
            return s;
        }
    }
}
