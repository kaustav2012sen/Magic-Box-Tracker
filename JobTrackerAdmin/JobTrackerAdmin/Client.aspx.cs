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
    public partial class WebForm3 : System.Web.UI.Page
    {
        AdminFacade _adminfacade = new AdminFacade();
        StringBuilder htmlTable = new StringBuilder();
        DataTable dt = new DataTable();

        protected void Page_Load(object sender, EventArgs e)
        {
            dt = _adminfacade.GetAllClientDetails();
            ClientDetailView();
           
        }

        private void ClientDetailView()
        {
            if(dt.Rows.Count>0)
            {
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    htmlTable.AppendLine("<tr>");

                    htmlTable.AppendLine("<td><a href=ClientAddEdit.aspx?id="+dt.Rows[i]["ClientID"]+" dataval="+ dt.Rows[i]["ClientID"]+">" + dt.Rows[i]["ClientName"] + "</a></td>");
                    htmlTable.AppendLine("<td>" + dt.Rows[i]["ClientAddress"] + "</td>");
                    htmlTable.AppendLine("<td>" + dt.Rows[i]["ClientContact"] + "</td>");
                    htmlTable.AppendLine("<td>" + dt.Rows[i]["ClientGST"] + "</td>");
                    htmlTable.AppendLine("<td>" + dt.Rows[i]["ClientPAN"] + "</td>");
                    htmlTable.AppendLine("<td>" + dt.Rows[i]["ClientRemarks"] + "</td>");
                   
                    htmlTable.AppendLine("</tr>");
                }

                DbDataPlaceholder.Controls.Add(new Literal { Text = htmlTable.ToString() });
            }
        }
    }
}