using AlbatrosSoft.DAL;
using AlbatrosSoft.Helpers;
using AlbatrosSoft.Model;
using AlbatrosSoft.Repository;
using Common;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace AlbatrosSoft.Views
{
    public partial class frmCustomer : System.Web.UI.Page, ISortableGridDataSource<ViewCustomer>
    {
        #region Propiedades
        [ThreadStatic]
        private ViewCustomerRepository _ViewCustomerRepository;

        public ViewCustomerRepository ViewCustomerRepository
        {
            get
            {
                if (this._ViewCustomerRepository == null)
                {
                    this._ViewCustomerRepository = new ViewCustomerRepository(new DataContext());
                }
                return this._ViewCustomerRepository;
            }
        }

        //registro seleccionado
        public string SelectedCustomerDocument { get; set; }

        //Atributos llenados a partir de los valores del formulario
        public string CustomerName
        {
            get
            {
                return this.txtCustomerName.Text;
            }
            set
            {
                this.txtCustomerName.Text = value;
            }
        }

        public string CustomerDocument
        {
            get
            {
                return this.txtCustomerDocument.Text;
            }
            set
            {
                this.txtCustomerDocument.Text = value;
            }
        }

        public string CustomerLastName
        {
            get
            {
                return this.txtCustomerLastName.Text;
            }
            set
            {
                this.txtCustomerLastName.Text = value;
            }
        }

        public string CustomerAddress
        {
            get
            {
                return this.txtCustomerAdress.Text;
            }
            set
            {
                this.txtCustomerAdress.Text = value;
            }
        }

        public string CustomerCellPhone1
        {
            get
            {
                return this.txtCellPhone1.Text;
            }
            set
            {
                this.txtCellPhone1.Text = value;
            }
        }

        public string CustomerTelephone1
        {
            get
            {
                return this.txtTelephone1.Text;
            }
            set
            {
                this.txtTelephone1.Text = value;
            }
        }

        public string CustomerTelephone2
        {
            get
            {
                return this.txtTelephone2.Text;
            }
            set
            {
                this.txtTelephone2.Text = value;
            }
        }

        public string CustomerCellPhone2
        {
            get
            {
                return this.txtCellPhone2.Text;
            }
            set
            {
                this.txtCellPhone2.Text = value;
            }
        }

        private List<ViewCustomer> _CustomerDataSource;

        protected List<ViewCustomer> CustomerDatasource
        {
            get
            {
                this._CustomerDataSource = ViewState["Customers"] as List<ViewCustomer>;
                if (this._CustomerDataSource == null)
                {
                    ViewState["Customers"] = new List<ViewCustomer>();
                    this._CustomerDataSource = ViewState["Customers"] as List<ViewCustomer>;
                }
                return this._CustomerDataSource;
            }
            set
            {
                ViewState["Customers"] = value;
                this._CustomerDataSource = ViewState["Customers"] as List<ViewCustomer>;
                this.grvCustomer.DataSource = value.ToList();
                this.grvCustomer.DataBind();
            }
        }

        public bool IsEditMode
        {
            get
            {
                return !this.txtCustomerDocument.Enabled;
            }
        }


        #endregion Propiedades


        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                this.LoadCustomer();
                this.btnDelete.Visible = false;
                this.btnSave.Enabled = true;
            }
        }

        #region Metodos formulario
        private void LoadCustomer()
        {
            this.ClearFields();
            var customers = this.ViewCustomerRepository.GetAll();
            this.CustomerDatasource = customers.ToList();
        }

        private void SelectCustomer(int customerDocument)
        {
            //this.ResultMessage = string.Empty;
            this.txtCustomerDocument.Enabled = false;
            this.btnDelete.Visible = true;
            this.btnSave.Enabled = true;
            var selectedCustomer = this.ViewCustomerRepository.GetCustomerByDocument(customerDocument);
            if (selectedCustomer != null)
            {
                this.CustomerName = selectedCustomer.Name;
                this.CustomerLastName = selectedCustomer.Lastname;
                this.CustomerDocument = Convert.ToString(selectedCustomer.Document.Value, CultureInfo.InvariantCulture);
                this.CustomerAddress = selectedCustomer.Address;
                this.CustomerTelephone1 = selectedCustomer.Telephone1;
                this.CustomerTelephone2 = selectedCustomer.Telephone2;
                this.CustomerCellPhone1 = selectedCustomer.MobilePhone1;
                this.CustomerCellPhone2 = selectedCustomer.MobilePhone2;
            }
        }

        private void SetCustomerProperties(ViewCustomer customerInfo)
        {
            customerInfo.Name = this.CustomerName;
            customerInfo.Lastname = this.CustomerLastName;
            customerInfo.Document = Convert.ToInt32(this.CustomerDocument, CultureInfo.InvariantCulture);
            customerInfo.Address = this.CustomerAddress;
            customerInfo.Telephone1 = this.CustomerTelephone1;
            customerInfo.Telephone2 = this.CustomerTelephone2;
            customerInfo.MobilePhone1 = this.CustomerCellPhone1;
            customerInfo.MobilePhone2 = this.CustomerCellPhone2;
        }

        /// <summary>
        /// Insertar tipo de mantenimiento
        /// </summary>
        private void InsertCustomer()
        {
            string resultMessage = string.Empty;
            ViewCustomer customer = new ViewCustomer();
            this.SetCustomerProperties(customer);
            this.ViewCustomerRepository.Insert(customer, out resultMessage);
            if (string.IsNullOrEmpty(resultMessage))
            {
                resultMessage = "Cliente creado satisfactoriamente";
                this.LoadCustomer();
            }
            this.ShowMessage(resultMessage);
        }

        /// <summary>
        /// Actualizar cliente
        /// </summary>
        private void UpdateCustomer()
        {
            try
            {
                string resultMessage = string.Empty;
                ViewCustomer customer = new ViewCustomer();
                this.SetCustomerProperties(customer);
                this.ViewCustomerRepository.Update(customer, out resultMessage);
                if (string.IsNullOrEmpty(resultMessage))
                {
                    resultMessage = "Cliente Actualizado satisfactoriamente";
                    this.LoadCustomer();
                }
                this.ShowMessage(resultMessage);
            }
            catch (Exception exc)
            {
                string resultMessage = Common.CommonUtils.GetErrorDetail(exc, true);
                this.ShowMessage(resultMessage);
            }
        }

        /// <summary>
        /// Eliminar cliente
        /// </summary>
        private void DeleteCustomer()
        {
            string resultMessage = string.Empty;
            int document;
            Int32.TryParse(this.CustomerDocument, NumberStyles.Any, CultureInfo.InvariantCulture, out document);
            this.ViewCustomerRepository.Delete(document, out resultMessage);
            if (string.IsNullOrEmpty(resultMessage))
            {
                resultMessage = "Cliente Eliminado satisfactoriamente";
                this.LoadCustomer();
            }
            this.ShowMessage(resultMessage);
        }

        private void ClearFields()
        {
            this.ShowMessage(string.Empty);
            this.txtCustomerDocument.Enabled = true;
            this.CustomerDocument = string.Empty;
            this.CustomerName = string.Empty;
            this.CustomerLastName = string.Empty;
            this.CustomerAddress = string.Empty;
            this.CustomerCellPhone1 = string.Empty;
            this.CustomerCellPhone2 = string.Empty;
            this.CustomerTelephone1 = string.Empty;
            this.CustomerTelephone2 = string.Empty;
            this.btnDelete.Visible = false;
            this.btnSave.Enabled = false;
        }
        #endregion Metodos formulario

        #region Metodos Controles
        #region Metodos Grid
        protected void grvCustomer_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            if (e != null)
            {
                if (e.CommandName == "editar")
                {
                    //Obtener link
                    LinkButton lb = ((LinkButton)e.CommandSource);
                    //Obtener valor clave seleccionado
                    this.SelectedCustomerDocument = ((HiddenField)lb.Parent.FindControl("hfRowkey")).Value;
                    this.SelectCustomer(Convert.ToInt32(this.SelectedCustomerDocument, CultureInfo.InvariantCulture));
                }
            }
        }
        #endregion Metodos Grid
        #region Metodos Botones
        protected void btnNewSearch_Click(object sender, EventArgs e)
        {
            this.LoadCustomer();
        }

        protected void btnNew_Click(object sender, EventArgs e)
        {
            this.ClearFields();
            this.btnSave.Enabled = true;
        }

        protected void btnSave_Click(object sender, EventArgs e)
        {
            if (this.IsEditMode)
            {
                this.UpdateCustomer();
            }
            else
            {
                this.InsertCustomer();
            }
        }

        protected void btnDelete_Click(object sender, EventArgs e)
        {
            if (this.IsEditMode)
            {
                this.DeleteCustomer();
            }
        }
        #endregion Metodos Botones

        private void ShowMessage(string message)
        {
            this.lblMessageError.Text = message;
        }

        #endregion Metodos Controles

        #region ISorteable Grid Region
        public string GridViewSortExpression
        {
            get
            {
                return ViewState["SortExpression"] as string ?? "NombreTipoMantenimiento";
            }
            set
            {
                var currentSortExpression = ViewState["SortExpression"] as string ?? string.Empty;
                if (!currentSortExpression.Equals(value))
                {
                    this.GridViewSortDirection = null;
                }
                ViewState["SortExpression"] = value;
            }
        }

        public string GridViewSortDirection
        {
            get
            {
                return ViewState["SortDirection"] as string ?? "DESC";
            }
            set
            {
                ViewState["SortDirection"] = value;
            }
        }

        public string GetSortDirection()
        {
            switch (this.GridViewSortDirection)
            {
                case "ASC":
                    this.GridViewSortDirection = "DESC";
                    break;
                case "DESC":
                    this.GridViewSortDirection = "ASC";
                    break;
            }
            return this.GridViewSortDirection;
        }

        public void SortGridView(GridView gv, GridViewSortEventArgs e, IEnumerable<ViewCustomer> dataSource)
        {
            if (e != null && gv != null)
            {
                this.GridViewSortExpression = e.SortExpression;
                this.CustomerDatasource = this.SortDataSource(dataSource, false).ToList();
                gv.PageIndex = 0;
                gv.DataBind();
            }
        }

        public void ChangeGridViewPageIndex(GridView gv, GridViewPageEventArgs e, IEnumerable<ViewCustomer> dataSource)
        {

            if (e != null && gv != null)
            {
                this.CustomerDatasource = this.SortDataSource(dataSource, true).ToList();
                gv.PageIndex = e.NewPageIndex;
                gv.DataBind();
            }
        }

        public IEnumerable<ViewCustomer> SortDataSource(IEnumerable<ViewCustomer> dataSource, bool isPageChanging)
        {
            IEnumerable<ViewCustomer> sortedData = null;
            if (dataSource != null)
            {
                var sortDirection = isPageChanging ? this.GridViewSortDirection : this.GetSortDirection();
                sortedData = SortingHelper<ViewCustomer>.SortBy(dataSource, this.GridViewSortExpression, sortDirection);
            }
            return sortedData;
        }

        protected void grvCustomer_Sorting(object sender, GridViewSortEventArgs e)
        {
            this.SortGridView(this.grvCustomer, e, this.CustomerDatasource);
        }

        protected void grvCustomer_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            this.ChangeGridViewPageIndex(this.grvCustomer, e, this.CustomerDatasource);
        }
        #endregion ISorteable Grid Region

        protected void btnSearch_Click(object sender, EventArgs e)
        {
            this.Search();
        }

        private void Search()
        {
            string resultMessage = string.Empty;
            var dataSource = this.CustomerDatasource.ToList();
            List<ViewCustomer> searchResult = null;
            Func<ViewCustomer, bool> filterCriteria = k => true;
            var filterHelper = new FilterHelper<ViewCustomer>();
            //Numero de serie
            if (!string.IsNullOrEmpty(this.CustomerName))
            {
                filterCriteria = filterHelper.AddFilterExpression(filterCriteria, k => k.Name.Trim()
                    .ToUpper(CultureInfo.InvariantCulture).Contains(this.CustomerName.Trim().ToUpper(CultureInfo.InvariantCulture)));
            }
            //Id Cliente
            if (!string.IsNullOrEmpty(this.CustomerLastName))
            {
                filterCriteria = filterHelper.AddFilterExpression(filterCriteria, k => k.Lastname.Trim()
                    .ToUpper(CultureInfo.InvariantCulture).Contains(this.CustomerLastName.Trim().ToUpper(CultureInfo.InvariantCulture)));
            }

            if (filterCriteria != null)
            {
                searchResult = dataSource.Where(filterCriteria).ToList();
                this.CustomerDatasource = searchResult;
                if (searchResult.Any())
                {
                    resultMessage = string.Format(CultureInfo.InvariantCulture, "({0}) elemento(s) encontrado(s).", searchResult.Count());
                    this.btnSave.Enabled = false;
                }
                else
                {
                    resultMessage = "No existen resultados que cumplan con los criterios de búsqueda ingresados.";
                }
                this.ShowMessage(resultMessage);
            }
            else
            {
                this.CustomerDatasource = dataSource;
            }
        }
    }
}