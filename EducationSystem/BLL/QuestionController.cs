using EducationSystem.DLL.Gateway;
using EducationSystem.DLL.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;

namespace EducationSystem.BLL
{
    public class QuestionController
    {
        QuestionGateway qg = new QuestionGateway();
        public bool AddQuestion(Question queObj)
        {
            return qg.AddQuestion(queObj);
        }

        public DataTable GetAllQuestions()
        {
            return qg.GetAllQuestions();
        }

        public DataRow GetQuestionById(int id)
        {
            return qg.GetQuestionById(id);
        }

        public DataTable GetAllTopics()
        {
            return new TopicGateway().GetAllTopics();
        }
    }
}