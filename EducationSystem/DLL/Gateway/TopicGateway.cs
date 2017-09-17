using EducationSystem.DLL.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace EducationSystem.DLL.Gateway
{
    /// <summary>
    /// CRUD for Topics
    /// </summary>
    public class TopicGateway
    {
        DBConnector db = new DBConnector();
        SqlCommand cmd;        
        SqlDataAdapter da;
        DataTable dt;
        DataRow dr;
        int isRowAffected;
        string query;

        public bool AddTopic(Topics topicObj)
        {
            try
            {
                db.conn.Open();
                query = "INSERT INTO Topic VALUES(@name,@desc,@img,@ia)";
                cmd = new SqlCommand(query, db.conn);
                cmd.Parameters.AddWithValue("@name", topicObj.TopicName);
                cmd.Parameters.AddWithValue("@desc", topicObj.TopicDesc);
                cmd.Parameters.AddWithValue("@img", topicObj.TopicImg);
                cmd.Parameters.AddWithValue("@ia", topicObj.isActive);

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

        public DataTable GetAllTopics()
        {
            try
            {
                query = "SELECT * FROM Topic order by TopicName";
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

        public DataRow GetTopicById(int id)
        {
            return null;
        }
    }
}