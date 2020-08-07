using AlbatrosSoft.DAL;
using AlbatrosSoft.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace AlbatrosSoft
{
    public partial class _Default : System.Web.UI.Page
    {

        protected void Page_Load(object sender, EventArgs e)
        {
            Response.Redirect("~/Views/Index.aspx");
        }

    }
}
