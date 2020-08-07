using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AlbatrosSoft.Model
{
    public class User
    {
        public string UserName { get; set; }
        public string Password { get; set; }


        public User()
        {

        }

        public User(string userName, string password )
        {
            this.UserName = userName;
            this.Password = password;
        }

       
    }
}