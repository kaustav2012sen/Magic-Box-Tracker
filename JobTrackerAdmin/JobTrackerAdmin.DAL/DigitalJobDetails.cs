using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;


namespace JobTrackerAdmin.DAL
{
    public class DigitalJobDetails
    {
        public DataSet GetAllDigitalJobDetails()
        {
            DataSet ds = new DataSet();
            SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["connect"].ToString());
            con.Open();
            SqlDataAdapter da = new SqlDataAdapter();
            SqlCommand cmd = new SqlCommand("stp_GetDigitalJobDetails", con);
            cmd.CommandType = CommandType.StoredProcedure;

            //cmd.Parameters.Add("@MenuTag", SqlDbType.BigInt).Value = 0;

            da.SelectCommand = cmd;
            da.Fill(ds);
            con.Close();
            return ds;
        }
    }
}