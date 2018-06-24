using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using JobTrackerAdmin.DAL;


namespace JobTrackerAdmin
{
    public partial class WebForm3 : System.Web.UI.Page
    {
        ClientData cd = new ClientData();
        protected void Page_Load(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            dt = cd.GetAllClients();
           
        }
    }
}