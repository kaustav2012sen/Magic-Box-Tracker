using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using JobTrackerAdmin.Facade;
using System.Text;
using JobTrackerAdmin.BO;


namespace JobTrackerAdmin
{
    public partial class WebForm14 : System.Web.UI.Page
    {
        AdminFacade _adminfacade = new AdminFacade();
        Instance oInstance = new Instance();
        StringBuilder htmlTable = new StringBuilder();
        public string JobDescription = string.Empty;
        public string MasterJobID = string.Empty;
        public string JobRemarks = string.Empty;
        string id = string.Empty;

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                BindDropdownAll();
            }

            id = Request.QueryString["id"];
            DataTable dt = new DataTable();

            if (Convert.ToInt32(id) > 0)
            {
                dt = _adminfacade.GetJobDetailByID(Convert.ToInt32(id));
            }

            if (dt.Rows.Count > 0)
            {
                JobDescription = dt.Rows[0]["JobDescription"].ToString();
                MasterJobID = dt.Rows[0]["MasterJobID"].ToString();
                JobRemarks = dt.Rows[0]["JobRemarks"].ToString();

            }
        }
        private void BindDropdownAll()
        {
            DataTable dt = new DataTable();
            dt = _adminfacade.GetAllJobDetails();
            BindDropdownJobList(dt);
            if (String.IsNullOrEmpty(id))
            {
                ViewJobDetails(dt);
            }
        }
        private void BindDropdownJobList(DataTable dt)
        {
           
            ddlNestedDescription.DataSource = dt;
            ddlNestedDescription.DataTextField = dt.Columns["JobDescription"].ToString();
            ddlNestedDescription.DataValueField = dt.Columns["JobID"].ToString();
            ddlNestedDescription.DataBind();
            ddlNestedDescription.Items.Insert(0, new ListItem("Select Master Job", "0"));


        }

        private void ViewJobDetails(DataTable dt)
        {
            if (dt.Rows.Count > 0)
            {
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    htmlTable.AppendLine("<tr>");

                    htmlTable.AppendLine("<td><a href=Job.aspx?id=" + dt.Rows[i]["JobID"] + " dataval=" + dt.Rows[i]["JobID"] + ">" + dt.Rows[i]["JobID"] + "</a></td>");
                    htmlTable.AppendLine("<td>" + dt.Rows[i]["JobDescription"] + "</td>");
                    htmlTable.AppendLine("<td>" + dt.Rows[i]["MasterJob"] + "</td>");
                    htmlTable.AppendLine("<td>" + dt.Rows[i]["JobRemarks"] + "</td>");

                    htmlTable.AppendLine("</tr>");
                }

                DbDataPlaceholder.Controls.Add(new Literal { Text = htmlTable.ToString() });
            }
        }

        protected void btn_Save_Click(object sender, EventArgs e)
        {
            int MasterJobID = Convert.ToInt32(ddlNestedDescription.SelectedValue);

            if (String.IsNullOrEmpty(id))
            {
                oInstance.Attr_Integer1 = 0;
                oInstance.Attr_NVarchar1 = Request.Form["JobDescription"];
                oInstance.Attr_Integer2 = Convert.ToInt32(Request.Form["MasterJobID"]);
                oInstance.Attr_NVarchar2 = Request.Form["JobRemarks"];

                int p = _adminfacade.SaveJobData(oInstance);
                if (p == 1)
                {
                    Response.Write("<script>alert('Data Inserted Successfully');</script>");
                    Page.Response.Redirect("Job.aspx");

                }
            }
            else
            {
                oInstance.Attr_Integer1 = Convert.ToInt32(id);
                oInstance.Attr_NVarchar1 = Request.Form["JobDescription"];
                oInstance.Attr_Integer2 = MasterJobID;
                oInstance.Attr_NVarchar2 = Request.Form["JobRemarks"];

                int p = _adminfacade.SaveJobData(oInstance);
                if (p == 2)
                {
                    Response.Write("<script>alert('Data Updated Successfully');</script>");
                    Page.Response.Redirect("Job.aspx");
                }

            }
            
        }

    }
}
