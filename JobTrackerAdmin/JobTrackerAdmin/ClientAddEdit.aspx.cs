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
        public string ClientTitle = string.Empty;
        
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

            if (String.IsNullOrEmpty(id))
            {
                oInstance.Attr_Integer1 = 0;
                oInstance.Attr_NVarchar1 = ClientName;
                oInstance.Attr_NVarchar2 = ClientAddress;
                oInstance.Attr_Double1 = ClientContact;
                oInstance.Attr_NVarchar3 = ClientGST;
                oInstance.Attr_NVarchar4 = ClientPAN;
                oInstance.Attr_NVarchar5 = ClientRemarks;

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
                oInstance.Attr_NVarchar1 = ClientName;
                oInstance.Attr_NVarchar2 = ClientAddress;
                oInstance.Attr_Double1 = ClientContact;
                oInstance.Attr_NVarchar3 = ClientGST;
                oInstance.Attr_NVarchar4 = ClientPAN;
                oInstance.Attr_NVarchar5 = ClientRemarks;

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