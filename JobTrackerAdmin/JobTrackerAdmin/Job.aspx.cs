using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using JobTrackerAdmin.Facade;
using System.Text;


namespace JobTrackerAdmin
{
    public partial class WebForm14 : System.Web.UI.Page
    {
        AdminFacade _adminfacade = new AdminFacade();
        DataTable dt = new DataTable();
        StringBuilder htmlTable = new StringBuilder();

        protected void Page_Load(object sender, EventArgs e)
        {
            


        }

    }
}
