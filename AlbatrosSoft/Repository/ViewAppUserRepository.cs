using AlbatrosSoft.DAL;
using AlbatrosSoft.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AlbatrosSoft.Repository
{
    public class ViewAppUserRepository:IRepository <ViewAppUser>
    {
        private DataContext DataContext;

        public ViewAppUserRepository()
        {

        }
        
        public ViewAppUserRepository(DataContext dataContext)
        {
            this.DataContext = dataContext;
        }

        public IEnumerable<ViewAppUser> GetAll()
        {
            return this.DataContext.spGetAppUser().ToList();
        }

        public ViewAppUser GetById(int id)
        {
            ViewAppUser appUser = new ViewAppUser();
            var appUsers = this.GetAll().ToList();
            appUser = appUsers.FirstOrDefault(u => u.UserID.Equals(id));
            return appUser;
        }

        public ViewAppUser GetUserByUserName(string userName)
        {
            ViewAppUser appUser = new ViewAppUser();
            var appUsers = this.GetAll().ToList();
            appUser = appUsers.FirstOrDefault(u => u.UserName.Trim().Equals(userName.Trim(), StringComparison.InvariantCultureIgnoreCase));
            return appUser;
        }

        public string AuthenticateUser(string userName, string password)
        {
            string resultMessage = string.Empty;
            var users = this.GetAll();
            var user = users.FirstOrDefault(e => e.UserName.Trim().Equals(userName.Trim(), StringComparison.InvariantCultureIgnoreCase) &&
                    e.Password.Trim().Equals(password.Trim(), StringComparison.InvariantCultureIgnoreCase));
            if (user == null)
            {
                resultMessage = "usuario no existe en el sistema";
            }
            return resultMessage;
        }

        public void Insert(ViewAppUser entity, out string resultMessage)
        {
            throw new NotImplementedException();
        }

        public void Update(ViewAppUser entity, out string resultMessage)
        {
            throw new NotImplementedException();
        }

        public void Delete(int entityId, out string resultMessage)
        {
            throw new NotImplementedException();
        }

        public void Save()
        {
            throw new NotImplementedException();
        }
    }
}