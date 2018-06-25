using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;
using System.Data;
using System.Configuration;

namespace JobTrackerAdmin.DAL
{
    public class PaperData
    {
        public DataTable GetAllPapers()  //To Retreive all the Data of the Papers
        {
            DataTable dt = new DataTable();
            SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["connect"].ToString());
            con.Open();
            SqlDataAdapter da = new SqlDataAdapter();
            SqlCommand cmd = new SqlCommand("stp_GetPaperDetails", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@PaperID", SqlDbType.BigInt).Value = 0;
            cmd.Parameters.Add("@PaperType", SqlDbType.VarChar).Value = "";
            cmd.Parameters.Add("@PaperRemarks", SqlDbType.VarChar).Value = "";
            cmd.Parameters.Add("@MenuTag", SqlDbType.BigInt).Value = 0;

            da.SelectCommand = cmd;
            da.Fill(dt);
            con.Close();
            return dt;
        }
    }
}