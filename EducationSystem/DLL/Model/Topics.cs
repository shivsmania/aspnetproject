using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EducationSystem.DLL.Model
{
    /// <summary>
    /// POCO for Topics
    /// Fields and Properties
    /// </summary>
    /// 
    public class Topics
    {
        private int id;
        private string name;
        private string desc;
        private string img;
        private bool isactive;

        public int TopicId
        {
            get
            {
                return id;
            }
            set
            {
                id = value;
            }
        }

        public string TopicName
        {
            get
            {
                return name;
            }
            set
            {
                name = value;
            }
        }
        public string TopicDesc
        {
            get
            {
                return desc;
            }
            set
            {
                desc = value;
            }
        }
        public string TopicImg
        {
            get
            {
                return img;
            }
            set
            {
                img = value;
            }
        }
        public bool isActive
        {
            get
            {
                return isactive;
            }
            set
            {
                isactive = value;
            }
        }
    }
}