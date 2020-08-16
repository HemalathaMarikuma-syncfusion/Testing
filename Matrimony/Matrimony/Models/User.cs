using System;
using System.Collections.Generic;
using System.Text;

namespace Matrimony.Models
{
    public class User
    {
        public string UserID { get; set; }
        public string UID { get; set; }
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string LastName { get; set; }
        public string DOB { get; set; }
        public string Star { get; set; }
        public string RegDate { get; set; }
        
        //  Objects
        public PlanInfo Plan { get; set; }
    }

    public class PlanInfo
    {
        public string Name { get; set; }
        public string Start { get; set; }
        public string End { get; set; }
    }

    public class UserInfo
    {
        public string LoginID { set; get; }
        public string UserName { set; get; }
        public string UserID { set; get; }
        public string AccountID { set; get; }
        public string AccountName { set; get; }
        public string Status { set; get; }
        public string URL { set; get; }
        public string Description { set; get; }
        public string LoginType { set; get; }

    }
}
