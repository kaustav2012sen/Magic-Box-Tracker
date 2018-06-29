using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using JobTrackerAdmin.Facade;
using System.Data;

namespace JobTrackerAdmin
{
    public partial class WebForm7 : System.Web.UI.Page
    {
        AdminFacade _adminfacade = new AdminFacade();
        public string ClientTitle = string.Empty;

        protected void Page_Load(object sender, EventArgs e)
        {
            string id = Request.QueryString["id"];
            DataTable dt = new DataTable();

            if (Convert.ToInt32(id)>0)
            {
                dt=_adminfacade.GetClientDetailByID(Convert.ToInt32(id));
            }

            if(dt.Rows.Count>0)
            {
                string ClientName = dt.Rows[0]["ClientNAme"].ToString();
                ClientTitle = ClientName;
            }
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