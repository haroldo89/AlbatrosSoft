using AlbatrosSoft.DAL;
using AlbatrosSoft.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace AlbatrosSoft
{
    public partial class Login : System.Web.UI.Page
    {
        /// <summary>
        /// IdUsuario del usuario
        /// </summary>
        protected string CurrentUserName
        {
            get
            {
                return this.Username.Text;
            }
            set
            {
                this.Username.Text = value;
            }
        }

        /// <summary>
        /// Password del usuario
        /// </summary>
        protected string CurrentPassword
        {
            get
            {
                return this.Password.Text;
            }
            set
            {
                this.Password.Text = value;
            }
        }

        /// <summary>
        /// Encapsula el mensaje de error de la autenticacion
        /// </summary>
        public string ErrorMessage
        {
            get
            {
                return this.Label1.Text;
            }
            set
            {
                this.Label1.Text = value;
            }
        }

        [ThreadStatic]
        private ViewAppUserRepository _ViewAppUserRepository;

        public ViewAppUserRepository ViewAppUserRepository
        {
            get
            {
                if (this._ViewAppUserRepository == null)
                {
                    this._ViewAppUserRepository = new ViewAppUserRepository(new DataContext());
                }
                return this._ViewAppUserRepository;
            }
        }

        protected String GetTime()
        {
            return DateTime.Now.ToString("yyyy");
        }


        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected bool IsAuthenticated
        {
            get
            {
                bool isAuthenticated = false;
                this.ErrorMessage = string.Empty;
                this.imgError.Visible = false;
                try
                {
                    string resultMessage = ViewAppUserRepository.AuthenticateUser(this.CurrentUserName, this.CurrentPassword);
                    if (string.IsNullOrEmpty(resultMessage))
                    {
                        isAuthenticated = true;
                    }
                    else
                    {
                        this.imgError.Visible = true;
                        this.ErrorMessage = resultMessage;
                    }
                }
                catch
                {
                    isAuthenticated = false;
                }
                return isAuthenticated;
            }
        }

        protected void btnLogin_Click(object sender, EventArgs e)
        {
            if (this.IsAuthenticated)
            {
                FormsAuthentication.RedirectFromLoginPage(this.CurrentUserName, false);
            }

        }
    }
}