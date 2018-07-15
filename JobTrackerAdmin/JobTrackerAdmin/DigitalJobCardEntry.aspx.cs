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
    public partial class WebForm11 : System.Web.UI.Page
    {
        AdminFacade _adminfacade = new AdminFacade();
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
        }

        private void BindDropDown(DataSet ds)
        {
            ddlClient.DataSource = ds.Tables[0];
            ddlClient.DataTextField = ds.Tables[0].Columns["ClientName"].ToString();
            ddlClient.DataValueField = ds.Tables[0].Columns["ClientID"].ToString();
            ddlClient.Items.Insert(0, new ListItem("-- Select --", String.Empty));
           
            ddlClient.DataBind();

            ddlPrinter.DataSource = ds.Tables[2];
            ddlPrinter.DataTextField = ds.Tables[2].Columns["MachineDescription"].ToString();
            ddlPrinter.DataValueField = ds.Tables[2].Columns["MachineID"].ToString();
            ddlPrinter.DataBind();
        }
    }
}