using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;
using System.Data;
using System.Configuration;

namespace JobTrackerAdmin.DAL
{
    public class VendorData
    {
        public DataTable GetAllVendors()  //To Retreive all the Data of the Vendors
        {
            DataTable dt = new DataTable();
            SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["connect"].ToString());
            con.Open();
            SqlDataAdapter da = new SqlDataAdapter();
            SqlCommand cmd = new SqlCommand("stp_GetVendorDetails", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@VendorID", SqlDbType.BigInt).Value = 0;
            cmd.Parameters.Add("@VendorName", SqlDbType.VarChar).Value = "";
            cmd.Parameters.Add("@VendorAddress", SqlDbType.VarChar).Value = "";
            cmd.Parameters.Add("@VendorContact", SqlDbType.Float).Value = 0.0;
            cmd.Parameters.Add("@VEndorEmail", SqlDbType.VarChar).Value = ""; 
            cmd.Parameters.Add("@VendorGST", SqlDbType.VarChar).Value = "";
            cmd.Parameters.Add("@VendorPAN", SqlDbType.VarChar).Value = "";
            cmd.Parameters.Add("@VendorRemarks", SqlDbType.VarChar).Value = "";
            cmd.Parameters.Add("@MenuTag", SqlDbType.BigInt).Value = 0;

            da.SelectCommand = cmd;
            da.Fill(dt);
            con.Close();
            return dt;
        }
    }
}