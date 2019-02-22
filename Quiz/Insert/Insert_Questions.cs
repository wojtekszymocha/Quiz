using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quiz
{
    class Insert_Questions : InsertClasses, IInsert_Questions
    {

        public string insert_srecord(Questions q)
        {
            string msg = " ";
            SqlConnection conn = new SqlConnection(connstring);

            try
            {
                SqlCommand cmd = new SqlCommand("[insert_questions]", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("questions_title", SqlDbType.NVarChar).Value = q.questions_title;
                cmd.Parameters.Add("questions_option_A ", SqlDbType.NVarChar, 200).Value = q.questions_option_A;
                cmd.Parameters.Add("questions_option_B ", SqlDbType.NVarChar, 200).Value = q.questions_option_B;
                cmd.Parameters.Add("questions_option_C ", SqlDbType.NVarChar, 200).Value = q.questions_option_C;
                cmd.Parameters.Add("questions_option_D ", SqlDbType.NVarChar, 200).Value = q.questions_option_D;
                cmd.Parameters.Add("questions_option_correct", SqlDbType.NVarChar, 200).Value = q.questions_option_correct;
                cmd.Parameters.Add("questions_addeddate", SqlDbType.NVarChar, 200).Value = q.questions_addeddate;
                cmd.Parameters.Add("questions_fk_admin", SqlDbType.NVarChar, 200).Value = q.questions_fk_admin;
                cmd.Parameters.Add("questions_fk_exam", SqlDbType.NVarChar, 200).Value = q.questions_fk_exam;

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
