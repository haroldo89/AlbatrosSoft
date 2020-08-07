﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace AlbatrosSoft.Model
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    using System.Data.Entity.Core.Objects;
    using System.Linq;
    
    public partial class ArionBDEntities1 : DbContext
    {
        public ArionBDEntities1()
            : base("name=ArionBDEntities1")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Customer> Customer { get; set; }
        public virtual DbSet<Department> Department { get; set; }
        public virtual DbSet<Employee> Employee { get; set; }
        public virtual DbSet<ViewDepartment> ViewDepartment { get; set; }
        public virtual DbSet<ViewCustomer> ViewCustomer { get; set; }
        public virtual DbSet<ViewEmployee> ViewEmployee { get; set; }
        public virtual DbSet<ViewAppUser> ViewAppUser { get; set; }
        public virtual DbSet<AppUser> AppUser { get; set; }
    
        public virtual ObjectResult<ViewDepartment> spGetDepartment()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<ViewDepartment>("spGetDepartment");
        }
    
        public virtual ObjectResult<ViewDepartment> spGetDepartment(MergeOption mergeOption)
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<ViewDepartment>("spGetDepartment", mergeOption);
        }
    
        public virtual ObjectResult<ViewCustomer> sptGetCustomer()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<ViewCustomer>("sptGetCustomer");
        }
    
        public virtual ObjectResult<ViewCustomer> sptGetCustomer(MergeOption mergeOption)
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<ViewCustomer>("sptGetCustomer", mergeOption);
        }
    
        public virtual int sptInsertDepartment(string description, ObjectParameter resultMessage)
        {
            var descriptionParameter = description != null ?
                new ObjectParameter("description", description) :
                new ObjectParameter("description", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sptInsertDepartment", descriptionParameter, resultMessage);
        }
    
        public virtual int sptInsertCustomer(string name, string lastname, string address, string telephone1, string telephone2, string mobilePhone1, string mobilePhone2, Nullable<int> document, ObjectParameter resultMessage)
        {
            var nameParameter = name != null ?
                new ObjectParameter("name", name) :
                new ObjectParameter("name", typeof(string));
    
            var lastnameParameter = lastname != null ?
                new ObjectParameter("lastname", lastname) :
                new ObjectParameter("lastname", typeof(string));
    
            var addressParameter = address != null ?
                new ObjectParameter("address", address) :
                new ObjectParameter("address", typeof(string));
    
            var telephone1Parameter = telephone1 != null ?
                new ObjectParameter("telephone1", telephone1) :
                new ObjectParameter("telephone1", typeof(string));
    
            var telephone2Parameter = telephone2 != null ?
                new ObjectParameter("telephone2", telephone2) :
                new ObjectParameter("telephone2", typeof(string));
    
            var mobilePhone1Parameter = mobilePhone1 != null ?
                new ObjectParameter("mobilePhone1", mobilePhone1) :
                new ObjectParameter("mobilePhone1", typeof(string));
    
            var mobilePhone2Parameter = mobilePhone2 != null ?
                new ObjectParameter("mobilePhone2", mobilePhone2) :
                new ObjectParameter("mobilePhone2", typeof(string));
    
            var documentParameter = document.HasValue ?
                new ObjectParameter("document", document) :
                new ObjectParameter("document", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sptInsertCustomer", nameParameter, lastnameParameter, addressParameter, telephone1Parameter, telephone2Parameter, mobilePhone1Parameter, mobilePhone2Parameter, documentParameter, resultMessage);
        }
    
        public virtual ObjectResult<ViewEmployee> sptGetEmployee()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<ViewEmployee>("sptGetEmployee");
        }
    
        public virtual ObjectResult<ViewEmployee> sptGetEmployee(MergeOption mergeOption)
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<ViewEmployee>("sptGetEmployee", mergeOption);
        }
    
        public virtual int sptInsertEmployee(string name, string lastname, string address, string telephone1, string telephone2, string mobilePhone1, string mobilePhone2, Nullable<int> departmentId, Nullable<int> document, ObjectParameter resultMessage)
        {
            var nameParameter = name != null ?
                new ObjectParameter("name", name) :
                new ObjectParameter("name", typeof(string));
    
            var lastnameParameter = lastname != null ?
                new ObjectParameter("lastname", lastname) :
                new ObjectParameter("lastname", typeof(string));
    
            var addressParameter = address != null ?
                new ObjectParameter("address", address) :
                new ObjectParameter("address", typeof(string));
    
            var telephone1Parameter = telephone1 != null ?
                new ObjectParameter("telephone1", telephone1) :
                new ObjectParameter("telephone1", typeof(string));
    
            var telephone2Parameter = telephone2 != null ?
                new ObjectParameter("telephone2", telephone2) :
                new ObjectParameter("telephone2", typeof(string));
    
            var mobilePhone1Parameter = mobilePhone1 != null ?
                new ObjectParameter("mobilePhone1", mobilePhone1) :
                new ObjectParameter("mobilePhone1", typeof(string));
    
            var mobilePhone2Parameter = mobilePhone2 != null ?
                new ObjectParameter("mobilePhone2", mobilePhone2) :
                new ObjectParameter("mobilePhone2", typeof(string));
    
            var departmentIdParameter = departmentId.HasValue ?
                new ObjectParameter("departmentId", departmentId) :
                new ObjectParameter("departmentId", typeof(int));
    
            var documentParameter = document.HasValue ?
                new ObjectParameter("document", document) :
                new ObjectParameter("document", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sptInsertEmployee", nameParameter, lastnameParameter, addressParameter, telephone1Parameter, telephone2Parameter, mobilePhone1Parameter, mobilePhone2Parameter, departmentIdParameter, documentParameter, resultMessage);
        }
    
        public virtual ObjectResult<ViewAppUser> sptGetAppUser()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<ViewAppUser>("sptGetAppUser");
        }
    
        public virtual ObjectResult<ViewAppUser> sptGetAppUser(MergeOption mergeOption)
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<ViewAppUser>("sptGetAppUser", mergeOption);
        }
    
        public virtual int sptInsertAppUser(string userName, string password, ObjectParameter resultMessage)
        {
            var userNameParameter = userName != null ?
                new ObjectParameter("UserName", userName) :
                new ObjectParameter("UserName", typeof(string));
    
            var passwordParameter = password != null ?
                new ObjectParameter("Password", password) :
                new ObjectParameter("Password", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sptInsertAppUser", userNameParameter, passwordParameter, resultMessage);
        }
    
        public virtual int sptDeleteCustomer(Nullable<int> document, ObjectParameter resultMessage)
        {
            var documentParameter = document.HasValue ?
                new ObjectParameter("document", document) :
                new ObjectParameter("document", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sptDeleteCustomer", documentParameter, resultMessage);
        }
    
        public virtual int spUpdateDepartment(Nullable<int> departmentId, string description, ObjectParameter resultMessage)
        {
            var departmentIdParameter = departmentId.HasValue ?
                new ObjectParameter("departmentId", departmentId) :
                new ObjectParameter("departmentId", typeof(int));
    
            var descriptionParameter = description != null ?
                new ObjectParameter("description", description) :
                new ObjectParameter("description", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("spUpdateDepartment", departmentIdParameter, descriptionParameter, resultMessage);
        }
    
        public virtual int sptUpdateCustomer(string name, string lastname, string address, string telephone1, string telephone2, string mobilePhone1, string mobilePhone2, Nullable<int> document, ObjectParameter resultMessage)
        {
            var nameParameter = name != null ?
                new ObjectParameter("name", name) :
                new ObjectParameter("name", typeof(string));
    
            var lastnameParameter = lastname != null ?
                new ObjectParameter("lastname", lastname) :
                new ObjectParameter("lastname", typeof(string));
    
            var addressParameter = address != null ?
                new ObjectParameter("address", address) :
                new ObjectParameter("address", typeof(string));
    
            var telephone1Parameter = telephone1 != null ?
                new ObjectParameter("telephone1", telephone1) :
                new ObjectParameter("telephone1", typeof(string));
    
            var telephone2Parameter = telephone2 != null ?
                new ObjectParameter("telephone2", telephone2) :
                new ObjectParameter("telephone2", typeof(string));
    
            var mobilePhone1Parameter = mobilePhone1 != null ?
                new ObjectParameter("mobilePhone1", mobilePhone1) :
                new ObjectParameter("mobilePhone1", typeof(string));
    
            var mobilePhone2Parameter = mobilePhone2 != null ?
                new ObjectParameter("mobilePhone2", mobilePhone2) :
                new ObjectParameter("mobilePhone2", typeof(string));
    
            var documentParameter = document.HasValue ?
                new ObjectParameter("document", document) :
                new ObjectParameter("document", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sptUpdateCustomer", nameParameter, lastnameParameter, addressParameter, telephone1Parameter, telephone2Parameter, mobilePhone1Parameter, mobilePhone2Parameter, documentParameter, resultMessage);
        }
    }
}