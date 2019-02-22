using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quiz
{
    class InsertStudent : InsertClasses, IInsertStudent
    {

        public string insert_student(string std_name, string std_password,string std_batchcode)
        {
            string msg = " ";
            SqlConnection conn = new SqlConnection(connstring);

            try
            {
                SqlCommand cmd = new SqlCommand("[insert_student_record]", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("student_name", SqlDbType.NVarChar).Value = std_name;
                cmd.Parameters.Add("student_batchcode", SqlDbType.NVarChar).Value = std_batchcode;
                cmd.Parameters.Add("student_password", SqlDbType.NVarChar).Value = std_password;
                cmd.Parameters.Add("student_ad_id", SqlDbType.NVarChar).Value= AdminLogin.fk_ad;

                conn.Open();
                cmd.ExecuteNonQuery();

                msg = "data successfully inserted!";
            }
            catch (Exception)
            {
                msg = "data is not successfully inserted!";
            }       
            finally
            {
                conn.Close();
            }

            return msg;
        }

    }
}
