using EducationSystem.DLL.Gateway;
using EducationSystem.DLL.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;

namespace EducationSystem.BLL
{
    /// <summary>
    /// Manage Topic related operations
    /// </summary>
    public class TopicController
    {
        TopicGateway tg = new TopicGateway();
        public bool AddTopic(Topics topicObj)
        {
            return tg.AddTopic(topicObj);
        }

        public DataTable GetAllTopics()
        {
            return tg.GetAllTopics();
        }

        public DataRow GetTopicById(int id)
        {
            return tg.GetTopicById(id);
        }
    }
}