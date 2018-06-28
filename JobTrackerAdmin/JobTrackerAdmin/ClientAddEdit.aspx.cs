using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using JobTrackerAdmin.Facade;

namespace JobTrackerAdmin
{
    public partial class WebForm7 : System.Web.UI.Page
    {
        AdminFacade _adminfacade = new AdminFacade();

        protected void Page_Load(object sender, EventArgs e)
        {
            string id = Request.QueryString["id"];

        }

        protected void btn_Save_Click(object sender, EventArgs e)
        {
            string ClientName = Request.Form["ClientName"];
            string ClientAddress = Request.Form["ClientAddress"];
            double ClientContact = Convert.ToDouble(Request.Form["ClientContact"]);
            string ClientGST = Request.Form["ClientGST"];
            string ClientPAN = Request.Form["ClientPAN"];
            string ClientRemarks = Request.Form["ClientRemarks"];

            int p = _adminfacade.SaveClientData(ClientName, ClientAddress, ClientContact, ClientGST, ClientPAN, ClientRemarks);
            if(p==1)
            {
                Response.Write("<script>alert('Data Inserted Successfully');</script>");
                Page.Response.Redirect(Page.Request.Url.ToString(), true);

            }



        }
    }
}