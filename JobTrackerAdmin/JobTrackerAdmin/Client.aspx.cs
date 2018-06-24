using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using JobTrackerAdmin.DAL;
using System.Text;

namespace JobTrackerAdmin
{
    public partial class WebForm3 : System.Web.UI.Page
    {
        ClientData cd = new ClientData();
        StringBuilder htmlTable = new StringBuilder();
        DataTable dt = new DataTable();

        protected void Page_Load(object sender, EventArgs e)
        {
            dt = cd.GetAllClients();
            ClientDetailView();
           
        }

        private void ClientDetailView()
        {
            if(dt.Rows.Count>0)
            {
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    htmlTable.AppendLine("<tr>");

                    htmlTable.AppendLine("<td><a href='#' dataval="+ dt.Rows[i]["ClientID"]+">" + dt.Rows[i]["ClientName"] + "</a></td>");
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