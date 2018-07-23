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
    public class JobData
    {
        public DataTable GetAllJob()  //To Retreive all the Data of the Vendors
        {
            DataTable dt = new DataTable();
            SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["connect"].ToString());
            con.Open();
            SqlDataAdapter da = new SqlDataAdapter();
            SqlCommand cmd = new SqlCommand("stp_GetJobDetails", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@MenuTag", SqlDbType.BigInt).Value = 0;

            da.SelectCommand = cmd;
            da.Fill(dt);
            con.Close();
            return dt;
        }
        public DataTable GetJobDetailByID(int JobID)
        {
            DataTable dt = new DataTable();
            SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["connect"].ToString());
            con.Open();
            SqlDataAdapter da = new SqlDataAdapter();
            SqlCommand cmd = new SqlCommand("stp_GetJobDetails", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@JobID", SqlDbType.Int).Value = JobID;
            cmd.Parameters.Add("@MenuTag", SqlDbType.BigInt).Value = 0;
            da.SelectCommand = cmd;
            da.Fill(dt);
            con.Close();
            return dt;

        }
        public int SaveJobDetails(Instance oInstance)
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
            cmd.Parameters.Add("@Attr_Integer2", SqlDbType.VarChar).Value = oInstance.Attr_Integer2;
            cmd.Parameters.Add("@Attr_NVarchar2", SqlDbType.VarChar).Value = oInstance.Attr_NVarchar2;
            cmd.Parameters.Add("@ActionTag", SqlDbType.Int).Value = (oInstance.Attr_Integer1 > 0) ? 1 : 0;
            cmd.Parameters.Add("@MenuTag", SqlDbType.BigInt).Value = 5;

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