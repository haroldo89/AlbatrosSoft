using AlbatrosSoft.DAL;
using AlbatrosSoft.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AlbatrosSoft.Repository
{
    public class ViewDepartmentRepository : IRepository<ViewDepartment>
    {
        private DataContext DataContext;

        public ViewDepartmentRepository(DataContext dataContext)
        {
            this.DataContext = dataContext;
        }

        public IEnumerable<ViewDepartment> GetAll()
        {
            return this.DataContext.spGetDepartment().ToList();
        }

        public ViewDepartment GetById(int id)
        {
            ViewDepartment department = null;
            try
            {
                var departments = this.GetAll();
                if (departments != null)
                {
                    department = departments.FirstOrDefault(d => d.DepartmentId.Equals(id));
                }
            }
            catch 
            {
                department = null;
            }
            return department;
        }

         public void Insert(ViewDepartment entity, out string resultMessage)
        {
            resultMessage = string.Empty;
            if (entity != null)
            {
                resultMessage = this.DataContext.spSaveDepartment(entity);
            }
        }


        public void Update(ViewDepartment entity, out string resultMessage)
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