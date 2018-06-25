using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;
using System.Data;
using System.Configuration;

namespace JobTrackerAdmin.DAL
{
    public class ClientData
    {
        public DataTable GetAllClients()
        {
            DataTable dt = new DataTable();
            SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["connect"].ToString());
            con.Open();
            SqlDataAdapter da = new SqlDataAdapter();
            SqlCommand cmd = new SqlCommand("stp_GetClientDetails", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@ClientID", SqlDbType.BigInt).Value = 0;
            cmd.Parameters.Add("@ClientName", SqlDbType.VarChar).Value = "";
            cmd.Parameters.Add("@ClientAddress", SqlDbType.VarChar).Value = "";
            cmd.Parameters.Add("@ClientContact", SqlDbType.Float).Value = 0.0;
            cmd.Parameters.Add("@ClientGST", SqlDbType.VarChar).Value = "";
            cmd.Parameters.Add("@ClientPAN", SqlDbType.VarChar).Value = "";
            cmd.Parameters.Add("@ClientRemarks", SqlDbType.VarChar).Value = "";
            cmd.Parameters.Add("@MenuTag", SqlDbType.BigInt).Value = 0;

            da.SelectCommand = cmd;
            da.Fill(dt);
            con.Close();
            return dt; 
        }

        

    }
}