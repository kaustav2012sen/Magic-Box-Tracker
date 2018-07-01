using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;
using System.Data;
using System.Configuration;
using JobTrackerAdmin.BO;

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
            cmd.Parameters.Add("@MenuTag", SqlDbType.BigInt).Value = 0;

            da.SelectCommand = cmd;
            da.Fill(dt);
            con.Close();
            return dt;
        }
        public DataTable GetVendorDetailByID(int VendorID)
        {
            DataTable dt = new DataTable();
            SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["connect"].ToString());
            con.Open();
            SqlDataAdapter da = new SqlDataAdapter();
            SqlCommand cmd = new SqlCommand("stp_GetVendorDetails", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@VendorID", SqlDbType.Int).Value = VendorID;
            cmd.Parameters.Add("@MenuTag", SqlDbType.BigInt).Value = 0;
            da.SelectCommand = cmd;
            da.Fill(dt);
            con.Close();
            return dt;

        }
        public int SaveVendorDetails(string VendorName, string VendorAddress, double VendorContact, string VendorEmail, string VendorGST, string VendorPAN, string VendorRemarks)
        {
            int i = 0;
            DataTable dt = new DataTable();
            SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["connect"].ToString());
            con.Open();
            SqlDataAdapter da = new SqlDataAdapter();
            SqlCommand cmd = new SqlCommand("stp_GetVendorDetails", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@VendorID", SqlDbType.BigInt).Value = 0;
            cmd.Parameters.Add("@VendorName", SqlDbType.VarChar).Value = VendorName;
            cmd.Parameters.Add("@VendorAddress", SqlDbType.VarChar).Value = VendorAddress;
            cmd.Parameters.Add("@VendorContact", SqlDbType.Float).Value = VendorContact;
            cmd.Parameters.Add("@VendorEmail", SqlDbType.VarChar).Value = VendorEmail;
            cmd.Parameters.Add("@VendorPAN", SqlDbType.VarChar).Value = VendorPAN;
            cmd.Parameters.Add("@VendorGST", SqlDbType.VarChar).Value = VendorGST;
            cmd.Parameters.Add("@VendorRemarks", SqlDbType.VarChar).Value = VendorRemarks;
            cmd.Parameters.Add("@MenuTag", SqlDbType.BigInt).Value = 1;

            da.SelectCommand = cmd;
            da.Fill(dt);
            con.Close();

            if (dt.Rows.Count > 0)
            {
                i = Convert.ToInt32(dt.Rows[0]["Status"]);
            }

            return i;
        }


        public int SaveVendorDetails(Instance oInstance)  
        {
            int i = 0;
            DataTable dt = new DataTable();
            SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["connect"].ToString());
            con.Open();
            SqlDataAdapter da = new SqlDataAdapter();
            SqlCommand cmd = new SqlCommand("stp_SetAllEntitiesByAction", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@Attr_Integer1", SqlDbType.BigInt).Value = oInstance.Attr_Integer1;
            cmd.Parameters.Add("@Attr_NVarchar1", SqlDbType.VarChar).Value = oInstance.Attr_NVarchar1;
            cmd.Parameters.Add("@Attr_NVarchar2", SqlDbType.VarChar).Value = oInstance.Attr_NVarchar2;
            cmd.Parameters.Add("@Attr_Float1", SqlDbType.Float).Value = oInstance.Attr_Double1;
            cmd.Parameters.Add("@Attr_NVarchar3", SqlDbType.VarChar).Value = oInstance.Attr_NVarchar3;
            cmd.Parameters.Add("@Attr_NVarchar4", SqlDbType.VarChar).Value = oInstance.Attr_NVarchar4;
            cmd.Parameters.Add("@Attr_NVarchar5", SqlDbType.VarChar).Value = oInstance.Attr_NVarchar5;
            cmd.Parameters.Add("@Attr_NVarchar6", SqlDbType.VarChar).Value = oInstance.Attr_NVarchar6;
            cmd.Parameters.Add("@ActionTag", SqlDbType.Int).Value = (oInstance.Attr_Integer1 > 0) ? 1 : 0;
            cmd.Parameters.Add("@MenuTag", SqlDbType.BigInt).Value = 1;

            da.SelectCommand = cmd;
            da.Fill(dt);
            con.Close();

            if (dt.Rows.Count > 0)
            {
                i = Convert.ToInt32(dt.Rows[0]["Status"]);
            }

            return i;
        }
    }
}