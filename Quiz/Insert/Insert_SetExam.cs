using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quiz
{
    class Insert_SetExam : InsertClasses, IInsert_SetExam
    {

        public string insert_SetExam(string date, string StudentID, string ExamID)
        {
            string msg = " ";
            SqlConnection conn = new SqlConnection(connstring);

            try
            {
                SqlCommand cmd = new SqlCommand("[INSERT_SET_EXAM]", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@set_exam_date", SqlDbType.NVarChar).Value = date;
                cmd.Parameters.Add("@student_id_fk", SqlDbType.Int).Value = StudentID;
                cmd.Parameters.Add("@exam_id_fk ", SqlDbType.Int).Value = ExamID;

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
