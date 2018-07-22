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

        string id = string.Empty;
        public string JobCardID = string.Empty;
        public string PaperQty = string.Empty;
        public string PrintQty = string.Empty;
        public string Remarks = string.Empty;

        protected void Page_Load(object sender, EventArgs e)
        {
            id = Request.QueryString["id"];
            DataTable dt = new DataTable();

            if (Convert.ToInt32(id) > 0)
            {
                dt = _adminfacade.GetDigitalJobDetailsByID(id);
                BindAllDropdown();
                ddlClient.SelectedValue = dt.Rows[0]["ClientID"].ToString();
                ddlPrinter.SelectedValue = dt.Rows[0]["PrinterID"].ToString();
                ddlPaper.SelectedValue = dt.Rows[0]["PaperID"].ToString();
                JobCardID = dt.Rows[0]["PK_intJobCardID"].ToString();
                PaperQty = dt.Rows[0]["Paper_Quantity"].ToString();
                PrintQty = dt.Rows[0]["Print_Quantity"].ToString();
                JobDescription.Text = dt.Rows[0]["JobDescription"].ToString();

            }
            if (!IsPostBack)
            {
                BindAllDropdown();
            }
        }

        private void BindAllDropdown()
        {
            DataSet ds = new DataSet();

            ds = _adminfacade.GetAllDigitalJobDetails();
            BindDropDown(ds);
            if (String.IsNullOrEmpty(id))
            {
                ViewDigitalJobDetails(ds);
            }
        }

        private void BindDropDown(DataSet ds)
        {
            ddlClient.DataSource = ds.Tables[0];
            ddlClient.DataTextField = ds.Tables[0].Columns["ClientName"].ToString();
            ddlClient.DataValueField = ds.Tables[0].Columns["ClientID"].ToString();
            ddlClient.DataBind();
            ddlClient.Items.Insert(0, new ListItem("-- Select --", "0"));

            ddlPaper.DataSource = ds.Tables[1];
            ddlPaper.DataTextField = ds.Tables[1].Columns["PaperType"].ToString();
            ddlPaper.DataValueField = ds.Tables[1].Columns["PaperID"].ToString();
            ddlPaper.DataBind();
            ddlPaper.Items.Insert(0, new ListItem("-- Select --", "0"));

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
                    htmlTable.AppendLine("<td>" + ds.Tables[3].Rows[i]["ClientName"] + "</td>");
                    htmlTable.AppendLine("<td>" + ds.Tables[3].Rows[i]["MachineDescription"] + "</td>");
                    htmlTable.AppendLine("<td>" + ds.Tables[3].Rows[i]["PaperType"] + "</td>");
                    htmlTable.AppendLine("<td>" + ds.Tables[3].Rows[i]["Paper_Quantity"] + "</td>");
                    htmlTable.AppendLine("<td>" + ds.Tables[3].Rows[i]["Print_Quantity"] + "</td>");
                    htmlTable.AppendLine("<td>" + ds.Tables[3].Rows[i]["JobDescription"] + "</td>");

                    htmlTable.AppendLine("</tr>");
                }

                DbDataPlaceholder.Controls.Add(new Literal { Text = htmlTable.ToString() });
            }
        }

        protected void btn_SaveJob_Click(object sender, EventArgs e)
        {
            int ClientID = Convert.ToInt32(ddlClient.SelectedValue);
            int MachineID = Convert.ToInt32(ddlPrinter.SelectedValue);
            int PaperID = Convert.ToInt32(ddlPaper.SelectedValue);
            int PaperQty = Convert.ToInt32(Request.Form["paperQty"]);
            int PrintQty = Convert.ToInt32(Request.Form["printQty"]);
            string DigitalRemarks = JobDescription.Text;
            int i=0;

            if (String.IsNullOrEmpty(id))
            {
                 i = _adminfacade.SaveDigitalJobDetails(ClientID, MachineID, PaperID, PaperQty, PrintQty, DigitalRemarks);

            }
            else
            {
                 i=_adminfacade.SaveDigitalJobDetails(id,ClientID, MachineID, PaperID, PaperQty, PrintQty, DigitalRemarks);
            }


            if (i>0)
            {
                Page.ClientScript.RegisterStartupScript(this.GetType(), "toastr_message", "toastr.success('Data Saved Successfully', 'Success','plain')", true);
                BindAllDropdown();
            }
            else if(i==-3)
            {
                Page.ClientScript.RegisterStartupScript(this.GetType(), "toastr_message", "toastr.success('Data Updated Successfully', 'Success','plain')", true);
                Response.Redirect("DigitalJobCardEntry.aspx");
            }

        }


        

    }

    
}