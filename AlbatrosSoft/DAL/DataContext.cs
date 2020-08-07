using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using AlbatrosSoft.Model;
using System.Data.Entity.Core.Objects;
using System.Globalization;

namespace AlbatrosSoft.DAL
{
    public class DataContext : DbContext
    {
        public DataContext()
            : base("name=ArionBDConectionString")
        {

        }
        // Declaracion de Tablas
        public DbSet<Department> Department { get; set; }
        public DbSet<Customer> Customer { get; set; }
        public DbSet<Employee> Employee { get; set; }
        //public DbSet<AppUser> AppUser { get; set;}
        //Declaracion de Vistas
        public DbSet<ViewDepartment> ViewDepartment { get; set; }
        public DbSet<ViewCustomer> ViewCustomer { get; set; }
        public DbSet<ViewEmployee> ViewEmployee { get; set; }
        public DbSet<ViewAppUser> ViewAppUser { get; set; }


        //Funciones sp
        public List<ViewDepartment> spGetDepartment()
        {
            ArionBDEntities1 context = new ArionBDEntities1();
            using (context)
            {
                return context.spGetDepartment().ToList();
            }
        }

        public List<ViewCustomer> sptGetCustomer()
        {
            ArionBDEntities1 context = new ArionBDEntities1();
            using (context)
            {
                return context.sptGetCustomer().ToList();
            }
        }

        public List<ViewEmployee> spGetEmployee()
        {
            ArionBDEntities1 context = new ArionBDEntities1();
            using (context)
            {
                return context.sptGetEmployee().ToList();
            }

        }

        public List<ViewAppUser> spGetAppUser()
        {
            ArionBDEntities1 context = new ArionBDEntities1();
            using (context)
            {
                return context.sptGetAppUser().ToList();
            }
        }


        #region CRUD Clientes
        /// <summary>
        /// Permite guardar clientes en la base de datos
        /// </summary>
        /// <param name="customer"></param>
        /// <returns></returns>
        public string spSaveCustomer(ViewCustomer customer)
        {
            ObjectParameter outputResultMessageParameter = new ObjectParameter("resultMessage", typeof(string));
            ArionBDEntities1 context = new ArionBDEntities1();
            using (context)
            {
                context.sptInsertCustomer(customer.Name, customer.Lastname, customer.Address, customer.Telephone1, customer.Telephone2,
                    customer.MobilePhone1, customer.MobilePhone2, customer.Document, outputResultMessageParameter);
                return Convert.ToString(outputResultMessageParameter.Value, CultureInfo.InvariantCulture);
            }
        }

        /// <summary>
        /// Permite actualizar clientes existentes en la base de datos
        /// </summary>
        /// <param name="customer"></param>
        /// <returns></returns>
        public string spUpdateCustomer(ViewCustomer customer)
        {
            ObjectParameter outputResultMessageParameter = new ObjectParameter("resultMessage", typeof(string));
            ArionBDEntities1 context = new ArionBDEntities1();
            using (context)
            {
                context.sptUpdateCustomer(customer.Name, customer.Lastname, customer.Address, customer.Telephone1, customer.Telephone2,
                    customer.MobilePhone1, customer.MobilePhone2, customer.Document, outputResultMessageParameter);
                return Convert.ToString(outputResultMessageParameter.Value, CultureInfo.InvariantCulture);
            }
        }

        /// <summary>
        /// Permite eliminar clientes existentes de la base de datos.
        /// </summary>
        /// <param name="document"></param>
        /// <returns></returns>
        public string spDeleteCustomer(int document)
        {
            ObjectParameter outputResultMessageParameter = new ObjectParameter("resultMessage", typeof(string));
            ArionBDEntities1 context = new ArionBDEntities1();
            using (context)
            {
                context.sptDeleteCustomer(document, outputResultMessageParameter);
                return Convert.ToString(outputResultMessageParameter.Value, CultureInfo.InvariantCulture);
            }
        }
        #endregion CRUD Clientes


        public string spSaveDepartment(ViewDepartment department)
        {
            ObjectParameter outputResultMessageParameter = new ObjectParameter("resultMessage", typeof(string));
            ArionBDEntities1 context = new ArionBDEntities1();
            using (context)
            {
                context.sptInsertDepartment(department.Description, outputResultMessageParameter);
                return Convert.ToString(outputResultMessageParameter.Value, CultureInfo.InvariantCulture);
            }
        }
    }
}