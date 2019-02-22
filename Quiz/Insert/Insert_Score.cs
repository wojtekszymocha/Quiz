using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quiz
{
    public class Insert_Score : InsertClasses, IInsert_Score
    {

        public string insert_Score(int score, int StudentID, int ExamID, float per)
        {
            string msg = " ";
            SqlConnection conn = new SqlConnection(connstring);

            try
            {
                SqlCommand cmd = new SqlCommand("[insert_score]", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@score", SqlDbType.Int).Value = score;
                cmd.Parameters.Add("@percentage", SqlDbType.Float).Value = per;
                cmd.Parameters.Add("@student_fk_id", SqlDbType.Int).Value = StudentID;
                cmd.Parameters.Add("@exam_fk_id", SqlDbType.Int).Value = ExamID;

                conn.Open();
                cmd.ExecuteNonQuery();

                msg = "Score successfully inserted!";
            }
            catch (Exception)
            {
                msg = "Score is not successfully inserted!";
            }
            finally
            {
                conn.Close();
            }

            return msg;
        }

    }
}
