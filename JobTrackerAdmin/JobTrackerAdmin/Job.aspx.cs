using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using JobTrackerAdmin.Facade;
using System.Text;
using System.Data.SqlClient;
using System.Configuration;

namespace JobTrackerAdmin
{
    public partial class WebForm14 : System.Web.UI.Page
    {
        AdminFacade _adminfacade = new AdminFacade();
        DataTable dt = new DataTable();
        StringBuilder htmlTable = new StringBuilder();

        protected void Page_Load(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["connect"].ToString());
            try
            {
                con.Open();
                SqlDataAdapter da = new SqlDataAdapter();
                SqlCommand cmd = new SqlCommand("stp_GetJobDetails", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@MenuTag", SqlDbType.BigInt).Value = 0;
                da.Fill(dt);

                DropDownList1.DataSource = dt;
                DropDownList1.DataBind();
                DropDownList1.DataTextField = "JobDescription";
                DropDownList1.DataValueField = "JobID";
                DropDownList1.DataBind();
            }
            catch (Exception er)
            {

            }
            finally
            {
                con.Close();
            }


        }

    }
}
