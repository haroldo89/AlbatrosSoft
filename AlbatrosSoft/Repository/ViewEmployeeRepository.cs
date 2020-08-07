using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using AlbatrosSoft.DAL;
using AlbatrosSoft.Model;

namespace AlbatrosSoft.Repository
{
    public class ViewEmployeeRepository : IRepository<ViewEmployee>
    {

        private DataContext DataContext;

        public ViewEmployeeRepository(DataContext dataContext)
        {
            this.DataContext = dataContext;
        }

        public IEnumerable<ViewEmployee> GetAll()
        {
            return this.DataContext.spGetEmployee().ToList();
        }

        public ViewEmployee GetById(int id)
        {
            ViewEmployee employee = null;
            try
            {
                var employees = this.GetAll();
                if (employees != null)
                {
                    employee = employees.FirstOrDefault(e => e.Document.Equals(id));
                }
            }
            catch
            {
                employee = null;
            }
            return employee;
        }

        public void Insert(ViewEmployee entity, out string resultMessage)
        {
            throw new NotImplementedException();
        }

        public void Update(ViewEmployee entity, out string resultMessage)
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