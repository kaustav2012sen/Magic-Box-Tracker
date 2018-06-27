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

<<<<<<< HEAD
        

=======
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
>>>>>>> 638f600aeaeabd11537f82622886612e7971f215
    }
}