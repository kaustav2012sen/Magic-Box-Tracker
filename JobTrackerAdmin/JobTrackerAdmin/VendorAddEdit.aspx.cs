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
    public partial class WebForm8 : System.Web.UI.Page
    {
        AdminFacade _adminfacade = new AdminFacade();
        Instance oInstance = new Instance();
        public string VendorName = string.Empty;
        public string VendorAddress = string.Empty;
        public string VendorContact = string.Empty;
        public string VendorEmail = string.Empty;
        public string VendorGST = string.Empty;
        public string VendorPAN = string.Empty;
        public string VendorRemarks = string.Empty;

        string id = string.Empty;

        protected void Page_Load(object sender, EventArgs e)
        {
            id = Request.QueryString["id"];
            DataTable dt = new DataTable();

            if (Convert.ToInt32(id) > 0)
            {
                dt = _adminfacade.GetVendorDetailByID(Convert.ToInt32(id));
            }

            if (dt.Rows.Count > 0)
            {
                VendorName = dt.Rows[0]["VendorName"].ToString();
                VendorAddress = dt.Rows[0]["VendorAddress"].ToString();
                VendorContact = dt.Rows[0]["VendorContact"].ToString();
                VendorEmail = dt.Rows[0]["VendorEmail"].ToString();
                VendorGST = dt.Rows[0]["VendorGST"].ToString();
                VendorPAN = dt.Rows[0]["VendorPAN"].ToString();
                VendorRemarks = dt.Rows[0]["VendorRemarks"].ToString();
      
            }

        }
        protected void btn_Save_Click(object sender, EventArgs e)
        {



            if (String.IsNullOrEmpty(id))
            {
                oInstance.Attr_Integer1 = 0;
                oInstance.Attr_NVarchar1 = Request.Form["VendorName"];
                oInstance.Attr_NVarchar2 = Request.Form["VendorAddress"];
                oInstance.Attr_Double1 = Convert.ToDouble(Request.Form["VendorContact"]);
                oInstance.Attr_NVarchar3 = Request.Form["VendorEmail"];
                oInstance.Attr_NVarchar4 = Request.Form["VendorGST"];
                oInstance.Attr_NVarchar5 = Request.Form["VendorPAN"];
                oInstance.Attr_NVarchar6 = Request.Form["VendorRemarks"];

                int p = _adminfacade.SaveVendorData(oInstance);
                if (p == 1)
                {
                    Response.Write("<script>alert('Data Inserted Successfully');</script>");
                    Page.Response.Redirect(Page.Request.Url.ToString(), true);

                }
            }
            else
            {
                oInstance.Attr_Integer1 = Convert.ToInt32(id);
                oInstance.Attr_NVarchar1 = Request.Form["VendorName"];
                oInstance.Attr_NVarchar2 = Request.Form["VendorAddress"];
                oInstance.Attr_Double1 = Convert.ToDouble(Request.Form["VendorContact"]);
                oInstance.Attr_NVarchar3 = Request.Form["VendorEmail"];
                oInstance.Attr_NVarchar4 = Request.Form["VendorGST"];
                oInstance.Attr_NVarchar5 = Request.Form["VendorPAN"];
                oInstance.Attr_NVarchar6 = Request.Form["VendorRemarks"];

                int p = _adminfacade.SaveVendorData(oInstance);
                if (p == 2)
                {
                    Response.Write("<script>alert('Data Updated Successfully');</script>");
                    Page.Response.Redirect(Page.Request.Url.ToString(), true);
                }

            }




        }
    }
}