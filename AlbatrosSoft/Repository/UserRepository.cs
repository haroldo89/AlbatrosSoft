using AlbatrosSoft.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AlbatrosSoft.Repository
{
    public partial class UserRepository
    {
        public string AuthenticateUser(string userName, string password)
        {
            string resultMessage = string.Empty;
            var users = this.GetUsers();
            var user = users.FirstOrDefault(e => e.UserName.Equals(userName,StringComparison.InvariantCultureIgnoreCase) && 
                    e.Password.Equals(password,StringComparison.InvariantCultureIgnoreCase));
            if (user == null)
            {
                resultMessage = "usuario no existe en el sistema";
            }
            return resultMessage;
        }

        public List<User> GetUsers()
        {
            ICollection<User> users = new List<User>()
            {
                new User
                {
                    UserName= "harold",
                    Password = "harold1"
                },
                new User
                {
                    UserName = "camilo",
                    Password = "camilo1"
                },
                new User
                {
                    UserName = "zairi",
                    Password = "zairi1"
                },
                new User
                {
                    UserName = "junior",
                    Password = "esgay"
                }
            };
            return users.ToList();
        }
    }
}