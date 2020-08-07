using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using AlbatrosSoft.DAL;
using AlbatrosSoft.Model;

namespace AlbatrosSoft.Repository
{
    public class ViewCustomerRepository : IRepository<ViewCustomer>
    {
        private DataContext DataContext;

        public ViewCustomerRepository(DataContext dataContext)
        {
            this.DataContext = dataContext;
        }
        public IEnumerable<ViewCustomer> GetAll()
        {
            return this.DataContext.sptGetCustomer().ToList();
        }

        public ViewCustomer GetById(int id)
        {
            ViewCustomer customer = null;
            try
            {
                var customers = this.GetAll();
                if (customers != null)
                {
                    customer = customers.FirstOrDefault(c => c.CustomerId.Equals(id));
                }
            }
            catch
            {
                customer = null;

            }
            return customer;

        }
        public ViewCustomer GetCustomerByDocument(int document)
        {
            ViewCustomer customer = null;
            try
            {
                var customers = this.GetAll();
                customer = customers.FirstOrDefault(c => c.Document.Equals(document));
            }
            catch
            {
                customer = null;
            }
            return customer;

        }

        public void Insert(ViewCustomer entity, out string resultMessage)
        {
            try
            {
                resultMessage = string.Empty;
                if (entity != null)
                {
                    resultMessage = this.DataContext.spSaveCustomer(entity);
                }
            }
            catch (Exception exc)
            {
                resultMessage = exc.Message;
            }
        }

        public void Update(ViewCustomer entity, out string resultMessage)
        {
            try
            {
                resultMessage = string.Empty;
                if (entity != null)
                {
                    resultMessage = this.DataContext.spUpdateCustomer(entity);
                }
            }
            catch (Exception exc)
            {
                resultMessage = exc.Message;
            }
        }

        public void Delete(int entityId, out string resultMessage)
        {
            try
            {
                resultMessage = this.DataContext.spDeleteCustomer(entityId);
            }
            catch (Exception exc)
            {
                resultMessage = exc.Message;
            }
        }

        public void Save()
        {
            throw new NotImplementedException();
        }
    }
}