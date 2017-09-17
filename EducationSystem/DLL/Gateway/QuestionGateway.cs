using EducationSystem.DLL.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace EducationSystem.DLL.Gateway
{
    public class QuestionGateway
    {
        DBConnector db = new DBConnector();
        SqlCommand cmd;
        SqlDataAdapter da;
        DataTable dt;
        DataRow dr;
        int isRowAffected;
        string query;

        public bool AddQuestion(Question queObj)
        {
            try
            {
                db.conn.Open();
                query = "INSERT INTO Questions VALUES(@name,@tid,@ian,@ia,getdate())";
                cmd = new SqlCommand(query, db.conn);
                cmd.Parameters.AddWithValue("@name", queObj.QuestionString);
                cmd.Parameters.AddWithValue("@tid", queObj.TopicId);
                cmd.Parameters.AddWithValue("@ian", queObj.isAnswered);
                cmd.Parameters.AddWithValue("@ia", queObj.isActive);

                isRowAffected = cmd.ExecuteNonQuery();
                db.conn.Close();

                if (isRowAffected > 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }


            }
            catch (Exception ee)
            {

                throw ee;
            }
        }

        public DataTable GetAllQuestions()
        {
            try
            {
                query = "SELECT * FROM Questions order by QuestionId desc";
                da = new SqlDataAdapter(query, db.conn);
                dt = new DataTable();
                da.Fill(dt);

                return dt;
            }
            catch (Exception ee)
            {

                throw ee;
            }
        }

        public DataRow GetQuestionById(int id)
        {
            return null;
        }

    }
}