using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EducationSystem.DLL.Model
{
    public class Question
    {
        private int id;
        private string name;
        private int topicid;
        private bool isans;
        private bool isactive;

        public int QuestionId
        {
            get { return id; }
            set { id = value; }
        }
        public string QuestionString
        {
            get { return name; }
            set { name = value; }
        }
        public int TopicId
        {
            get { return topicid; }
            set { topicid = value; }
        }
        public bool isAnswered
        {
            get { return isans; }
            set { isans = value; }
        }
        public bool isActive
        {
            get { return isactive; }
            set { isactive = value; }
        }
    }
}