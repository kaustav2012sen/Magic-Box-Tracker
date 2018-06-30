using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using JobTrackerAdmin.Facade;
using JobTrackerAdmin.BO;
using System.Data;

namespace JobTrackerAdmin
{
    public partial class WebForm7 : System.Web.UI.Page
    {
        AdminFacade _adminfacade = new AdminFacade();
        Instance oInstance = new Instance();
        public string ClientName = string.Empty;
        public string ClientAddress = string.Empty;
        public string ClientContact = string.Empty;
        public string ClientGST = string.Empty;
        public string ClientPAN = string.Empty;
        public string ClientRemarks = string.Empty;
        
        string id = string.Empty;

        protected void Page_Load(object sender, EventArgs e)
        {
            id = Request.QueryString["id"];
            DataTable dt = new DataTable();

            if (Convert.ToInt32(id)>0)
            {
                dt=_adminfacade.GetClientDetailByID(Convert.ToInt32(id));
            }

            if(dt.Rows.Count>0)
            {
                ClientName = dt.Rows[0]["ClientNAme"].ToString();
                ClientAddress = dt.Rows[0]["ClientAddress"].ToString();
                ClientContact = dt.Rows[0]["ClientContact"].ToString();
                ClientGST = dt.Rows[0]["ClientGST"].ToString();
                ClientPAN = dt.Rows[0]["ClientPAN"].ToString();
                ClientRemarks = dt.Rows[0]["ClientRemarks"].ToString();
                
            }
        }

        protected void btn_Save_Click(object sender, EventArgs e)
        {

            

            if (String.IsNullOrEmpty(id))
            {
                oInstance.Attr_Integer1 = 0;
                oInstance.Attr_NVarchar1 = Request.Form["ClientName"];
                oInstance.Attr_NVarchar2 = Request.Form["ClientAddress"];
                oInstance.Attr_Double1 = Convert.ToDouble(Request.Form["ClientContact"]);
                oInstance.Attr_NVarchar3 = Request.Form["ClientGST"];
                oInstance.Attr_NVarchar4 = Request.Form["ClientPAN"];
                oInstance.Attr_NVarchar5 = Request.Form["ClientRemarks"];

                //int p = _adminfacade.SaveClientData(ClientName, ClientAddress, ClientContact, ClientGST, ClientPAN, ClientRemarks);
                int p = _adminfacade.SaveClientData(oInstance);
                if (p == 1)
                {
                    Response.Write("<script>alert('Data Inserted Successfully');</script>");
                    Page.Response.Redirect(Page.Request.Url.ToString(), true);

                }
            }
            else
            {
                oInstance.Attr_Integer1 = Convert.ToInt32(id);
                oInstance.Attr_NVarchar1 = Request.Form["ClientName"];
                oInstance.Attr_NVarchar2 = Request.Form["ClientAddress"];
                oInstance.Attr_Double1 = Convert.ToDouble(Request.Form["ClientContact"]);
                oInstance.Attr_NVarchar3 = Request.Form["ClientGST"];
                oInstance.Attr_NVarchar4 = Request.Form["ClientPAN"];
                oInstance.Attr_NVarchar5 = Request.Form["ClientRemarks"];

                int p = _adminfacade.SaveClientData(oInstance);
                if(p==2)
                {
                    Response.Write("<script>alert('Data Updated Successfully');</script>");
                    Page.Response.Redirect(Page.Request.Url.ToString(), true);
                }

            }
            



        }
    }
}