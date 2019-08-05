using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebService1
{

    public class User
    {
        public int uID { get; set; }
        public string uname { get; set; }
        public string uPass { get; set; }
        public string uPhone { get; set; }
        public string phoneID { get; set; }
        public User() { }
        public User(int uID, string uname, string uPhone, string uPass,string phoneID)
        {
            this.uID = uID;
            this.uname = uname;
            this.uPhone = uPhone;
            this.uPass = uPass;
            this.phoneID = phoneID;

        }
    }
}