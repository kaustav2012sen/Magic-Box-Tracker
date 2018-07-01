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
    public partial class WebForm2 : System.Web.UI.Page
    {
        AdminFacade _adminfacade = new AdminFacade();
        StringBuilder htmlTable = new StringBuilder();
        DataTable dt = new DataTable();

        protected void Page_Load(object sender, EventArgs e)
        {
            dt = _adminfacade.GetAllVendorDetails();
            VendorDetailView();
        }

        private void VendorDetailView()
        {
            if (dt.Rows.Count > 0)
            {
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    htmlTable.AppendLine("<tr>");

                    htmlTable.AppendLine("<td><a href='#' dataval=" + dt.Rows[i]["VendorID"] + ">" + dt.Rows[i]["VendorName"] + "</a></td>");
                    htmlTable.AppendLine("<td>" + dt.Rows[i]["VendorAddress"] + "</td>");
                    htmlTable.AppendLine("<td>" + dt.Rows[i]["VendorContact"] + "</td>");
                    htmlTable.AppendLine("<td>" + dt.Rows[i]["VendorEmail"] + "</td>");
                    htmlTable.AppendLine("<td>" + dt.Rows[i]["VendorPAN"] + "</td>");
                    htmlTable.AppendLine("<td>" + dt.Rows[i]["VendorGST"] + "</td>");
                    htmlTable.AppendLine("<td>" + dt.Rows[i]["VendorRemarks"] + "</td>");

                    htmlTable.AppendLine("</tr>");
                }

                DbDataPlaceholder.Controls.Add(new Literal { Text = htmlTable.ToString() });
            }
        }
    }
}