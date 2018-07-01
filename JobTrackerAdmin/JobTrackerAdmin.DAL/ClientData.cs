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
    public class ClientData
    {
        #region Get Clients
        public DataTable GetAllClients()  //To Retreive all the Data of the Clients
        {
            DataTable dt = new DataTable();
            SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["connect"].ToString());
            con.Open();
            SqlDataAdapter da = new SqlDataAdapter();
            SqlCommand cmd = new SqlCommand("stp_GetClientDetails", con);
            cmd.CommandType = CommandType.StoredProcedure;
            
            cmd.Parameters.Add("@MenuTag", SqlDbType.BigInt).Value = 0;

            da.SelectCommand = cmd;
            da.Fill(dt);
            con.Close();
            return dt; 
        }

        public DataTable GetClientDetailByID(int CLientID)
        {
            DataTable dt = new DataTable();
            SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["connect"].ToString());
            con.Open();
            SqlDataAdapter da = new SqlDataAdapter();
            SqlCommand cmd = new SqlCommand("stp_GetClientDetails", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@ClientID", SqlDbType.Int).Value = CLientID;
            cmd.Parameters.Add("@MenuTag", SqlDbType.BigInt).Value = 0;
            da.SelectCommand = cmd;
            da.Fill(dt);
            con.Close();
            return dt;
        }

        #endregion



        #region Save(Add/Edit) Client Details


        public int SaveClientDetails(string ClientName,string ClientAddress, double ClientContact, string ClientGST, string ClientPAN, string ClientRemarks)
        {
            int i=0;
            DataTable dt = new DataTable();
            SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["connect"].ToString());
            con.Open();
            SqlDataAdapter da = new SqlDataAdapter();
            SqlCommand cmd = new SqlCommand("stp_GetClientDetails", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@ClientID", SqlDbType.BigInt).Value = 0;
            cmd.Parameters.Add("@ClientName", SqlDbType.VarChar).Value = ClientName;
            cmd.Parameters.Add("@ClientAddress", SqlDbType.VarChar).Value = ClientAddress;
            cmd.Parameters.Add("@ClientContact", SqlDbType.Float).Value = ClientContact;
            cmd.Parameters.Add("@ClientGST", SqlDbType.VarChar).Value = ClientGST;
            cmd.Parameters.Add("@ClientPAN", SqlDbType.VarChar).Value = ClientPAN;
            cmd.Parameters.Add("@ClientRemarks", SqlDbType.VarChar).Value = ClientRemarks;
            cmd.Parameters.Add("@MenuTag", SqlDbType.BigInt).Value = 1;

            da.SelectCommand = cmd;
            da.Fill(dt);
            con.Close();

            if(dt.Rows.Count>0)
            {
                i = Convert.ToInt32(dt.Rows[0]["Status"]);
            }
           
            return i; 
        }


        public int SaveClientDetails(Instance oInstance)   // Function to Save Add/Edit Client Details
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
            cmd.Parameters.Add("@ActionTag", SqlDbType.Int).Value = (oInstance.Attr_Integer1 > 0) ? 1 : 0;
            cmd.Parameters.Add("@MenuTag", SqlDbType.BigInt).Value = 0;

            da.SelectCommand = cmd;
            da.Fill(dt);
            con.Close();

            if (dt.Rows.Count > 0)
            {
                i = Convert.ToInt32(dt.Rows[0]["Status"]);
            }

            return i;
        }

#endregion

    }
}