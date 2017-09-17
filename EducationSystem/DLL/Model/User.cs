using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EducationSystem.DLL.Model
{
    public class User
    {
        private int uid;
        private string fname;
        private string email;
        private string pwd;
        private string edu;
        private string mno;
        private string dp;
        private bool isactive;

        public int UserId { get { return uid; } set { uid = value; } }
        public string FullName { get { return fname; } set { fname = value; } }
        public string Email { get { return email; } set { email = value; } }
        public string Password { get { return pwd; } set { pwd = value; } }
        public string Education { get { return edu; } set { edu = value; } }
        public string MobileNo { get { return mno; } set { mno = value; } }
        public string ProfilePic { get { return dp; } set { dp = value; } }
        public bool isActive { get { return isactive; } set { isactive = value; } }
    }
}