using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using JobTrackerAdmin.Facade;
using System.Data;
using System.Text;

namespace JobTrackerAdmin
{
    public partial class WebForm11 : System.Web.UI.Page
    {
        AdminFacade _adminfacade = new AdminFacade();
        StringBuilder htmlTable = new StringBuilder();



        protected void Page_Load(object sender, EventArgs e)
        {
            if(!IsPostBack)
            {
                BindAllDropdown();
            }
        }

        private void BindAllDropdown()
        {
            DataSet ds = new DataSet();

            ds = _adminfacade.GetAllDigitalJobDetails();
            BindDropDown(ds);
            ViewDigitalJobDetails(ds);
        }

        private void BindDropDown(DataSet ds)
        {
            ddlClient.DataSource = ds.Tables[0];
            ddlClient.DataTextField = ds.Tables[0].Columns["ClientName"].ToString();
            ddlClient.DataValueField = ds.Tables[0].Columns["ClientID"].ToString();
            ddlClient.DataBind();
            ddlClient.Items.Insert(0, new ListItem("-- Select --", "0"));

            ddlPrinter.DataSource = ds.Tables[2];
            ddlPrinter.DataTextField = ds.Tables[2].Columns["MachineDescription"].ToString();
            ddlPrinter.DataValueField = ds.Tables[2].Columns["MachineID"].ToString();
            ddlPrinter.DataBind();
            ddlPrinter.Items.Insert(0, new ListItem("-- Select --", "0"));

        }

        private void ViewDigitalJobDetails(DataSet ds)
        {
            if (ds.Tables[3].Rows.Count>0)
            {
                for (int i = 0; i < ds.Tables[3].Rows.Count; i++)
                {
                    htmlTable.AppendLine("<tr>");

                    htmlTable.AppendLine("<td><a href=DigitalJobCardEntry.aspx?id=" + ds.Tables[3].Rows[i]["JobCardID"] + " dataval=" +ds.Tables[3].Rows[i]["JobCardID"] + ">" +ds.Tables[3].Rows[i]["JobCardID"] + "</a></td>");
                    htmlTable.AppendLine("<td>" +ds.Tables[3].Rows[i]["ClientName"] + "</td>");
                    htmlTable.AppendLine("<td>" +ds.Tables[3].Rows[i]["MachineDescription"] + "</td>");
                    htmlTable.AppendLine("<td>" + "" + "</td>");
                    htmlTable.AppendLine("<td>" +ds.Tables[3].Rows[i]["Paper_Quantity"] + "</td>");
                    htmlTable.AppendLine("<td>" +ds.Tables[3].Rows[i]["Print_Quantity"] + "</td>");
                    htmlTable.AppendLine("<td>" +ds.Tables[3].Rows[i]["JobDescription"] + "</td>");

                    htmlTable.AppendLine("</tr>");
                }

                DbDataPlaceholder.Controls.Add(new Literal { Text = htmlTable.ToString() });
            }
        }

        protected void btn_SaveJob_Click(object sender, EventArgs e)
        {
            int ClientID = Convert.ToInt32(ddlClient.SelectedValue);
            int MachineID = Convert.ToInt32(ddlPrinter.SelectedValue);
            int PaperQty = Convert.ToInt32(Request.Form["paperQty"]);
            int PrintQty = Convert.ToInt32(Request.Form["printQty"]);
            string DigitalRemarks = Request.Form["DIgitalRemarks"];

            int i = _adminfacade.SaveDigitalJobDetails(ClientID, MachineID, PaperQty, PrintQty, DigitalRemarks);

            if(i>0)
            {
                Page.ClientScript.RegisterStartupScript(this.GetType(), "toastr_message", "toastr.info('Data Saved Successfully', 'Success')", true);
            }

        }


        

    }

    
}