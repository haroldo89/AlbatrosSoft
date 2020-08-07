using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace AlbatrosSoft
{
    public partial class SiteMaster : System.Web.UI.MasterPage
    {
        protected string CurrentUserName
        {
            get
            {
                return HttpContext.Current.User.Identity.Name;
            }
        }

        protected String GetTime()
        {
            return DateTime.Now.ToString("yyyy");
        }

        protected void Page_Load(object sender, EventArgs e)
        {
            this.SetInitialState();
        }

        private void SetInitialState()
        {
            lnkUser.InnerText = this.CurrentUserName.ToUpper();
            lnkCloseUser.InnerText = this.CurrentUserName.ToUpper();
            lblDate.Text = DateTime.Now.ToString("yyyy-MM-dd");
        }
    }
}
