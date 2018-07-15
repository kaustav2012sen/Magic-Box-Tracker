﻿using System;
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

        public int SaveDigitalJobDetails(int ClientID,int MachineID,int PaperQty,int PrintQty, string Remarks)
        {
            int i = 0;
            SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["connect"].ToString());
            con.Open();


            SqlCommand cmd = new SqlCommand("stp_SaveDigitalJobCard", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@ClientID ", SqlDbType.Int).Value = ClientID;
            cmd.Parameters.Add("@PrinterID ", SqlDbType.Int).Value = MachineID;
            cmd.Parameters.Add("@PaperQuantity", SqlDbType.Int).Value = PaperQty;
            cmd.Parameters.Add("@PrintQuantity", SqlDbType.Int).Value = PrintQty;
            cmd.Parameters.Add("DigitalRemarks", SqlDbType.NVarChar).Value = Remarks;
            cmd.Parameters.Add("@Status", SqlDbType.TinyInt).Direction = ParameterDirection.Output;
            cmd.ExecuteNonQuery();
            i = Convert.ToInt32(cmd.Parameters["@Status"].Value);


            return i;
        }
    }
}