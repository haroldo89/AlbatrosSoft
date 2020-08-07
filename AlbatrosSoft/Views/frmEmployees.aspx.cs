using AlbatrosSoft.DAL;
using AlbatrosSoft.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace AlbatrosSoft.Views
{
    public partial class frmEmployees : System.Web.UI.Page
    {

        [ThreadStatic]
        private ViewEmployeeRepository _ViewEmployeeRepository;

        public ViewEmployeeRepository ViewEmployeeRepository
        {
            get
            {
                if (this._ViewEmployeeRepository == null)
                {
                    this._ViewEmployeeRepository = new ViewEmployeeRepository(new DataContext());
                }
                return this._ViewEmployeeRepository;
            }
        }


        protected void Page_Load(object sender, EventArgs e)
        {
            this.LoadEmployees();
        }

        private void LoadEmployees()
        {
            var employees = this.ViewEmployeeRepository.GetAll();
            this.grvEmployes.DataSource = employees.ToList();
            this.grvEmployes.DataBind();
        }
    }
}