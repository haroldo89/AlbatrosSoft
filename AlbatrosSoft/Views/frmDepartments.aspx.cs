using AlbatrosSoft.DAL;
using AlbatrosSoft.Model;
using AlbatrosSoft.Repository;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Common;

namespace AlbatrosSoft.Views
{
    public partial class frmDepartments : System.Web.UI.Page
    {
        #region Propiedades
        [ThreadStatic]
        private ViewDepartmentRepository _ViewDepartmentRepository;
        public ViewDepartmentRepository ViewDepartmentRepository
        {
            get
            {
                if (this._ViewDepartmentRepository == null)
                {
                    this._ViewDepartmentRepository = new ViewDepartmentRepository(new DataContext());
                }
                return this._ViewDepartmentRepository;
            }
        }

        public string SelectedDepartmentId { get; set; }

        public string DepartmentDescription
        {
            get
            {
                return this.txtDescriptionName.Text;
            }
            set
            {
                if (!string.IsNullOrEmpty(value))
                {
                    this.txtDescriptionName.Text = value;
                }
            }
        }
        #endregion Propiedades



        protected void Page_Load(object sender, EventArgs e)
        {
            this.LoadDepartments();
        }


        #region Metodos formulario
        private void LoadDepartments()
        {
            var departments = this.ViewDepartmentRepository.GetAll();
            this.grvDepartment.DataSource = departments.ToList();
            this.grvDepartment.DataBind();
        }

        private void SelectDepartment(int departmentId)
        {
            //this.ResultMessage = string.Empty;
            var selectedDepartment = this.ViewDepartmentRepository.GetById(departmentId);
            if (selectedDepartment != null)
            {
                this.DepartmentDescription = selectedDepartment.Description;
                
            }
        }


        private void SetDepartment (ViewDepartment departmentInfo)
        {
            departmentInfo.Description = this.DepartmentDescription;
            
        }

        private void InsertDepartment()
        {
            try
            {
                string resultMessage = string.Empty;
                //bool operationSucessfull = false;
                ViewDepartment department = new ViewDepartment();

                //maintenanceType.IdTipoMantenimiento = Convert.ToInt32(DEFAULT_ITEM_VALUE, CultureInfo.InvariantCulture);
                this.SetDepartment(department);
                this.ViewDepartmentRepository.Insert(department, out resultMessage);

                if (string.IsNullOrEmpty(resultMessage))
                {
                    //operationSucessfull = true;
                    resultMessage = "Departamento Creado Satisfactoriamente";
                    this.LoadDepartments();
                }
                //this.ucMaintenanceTypes.Visible = false;
                this.ShowMessage(resultMessage);
                int numero1 = 1;
                int numero2 = 0;
                var algo = numero1 / numero2;
            }
            catch (Exception exc)
            {
                var message = CommonUtils.GetErrorDetail(exc, true);
                this.ShowMessage(message);
            }
        }
        #endregion Metodos formulario


        #region Metodos Controles
        protected void grvDepartment_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            if (e != null)
            {
                if (e.CommandName == "editar")
                {
                    //Obtener link
                    LinkButton lb = ((LinkButton)e.CommandSource);
                    //Obtener valor clave seleccionado
                    this.SelectedDepartmentId = ((HiddenField)lb.Parent.FindControl("hfRowkey")).Value;
                    this.SelectDepartment(Convert.ToInt32(this.SelectedDepartmentId, CultureInfo.InvariantCulture));
                }
            }
        }

        protected void btnSave_Click(object sender, EventArgs e)
        {
            //if (this.IsEditMode)
            //{
            //    this.UpdateMaintenanceType();
            //}
            //else
            //{
            this.InsertDepartment();
            //}
        }

        private void ShowMessage(string message)
        {
            this.lblMessageError.Text = message;
        }

        #endregion Metodos Controles

    }
}