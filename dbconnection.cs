﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace newTestvms
{
    public class dbconnection
    {
        SqlConnection con = new SqlConnection("Data Source=DESKTOP-PVBM0T3\\SQLEXPRESS; Initial Catalog=VMS;Integrated Security=true;");
        SqlCommand cmd;
        SqlDataAdapter adapt;
        //ID variable used in Updating and Deleting Record  
        int ID = 0;

        public SqlCommand ExecuteQueries(string query)
        {
            con.Open();
            cmd = new SqlCommand(query, con);
            //cmd.ExecuteNonQuery();
            return cmd;
            //con.Close();
        }

        public void CloseConnection()
        {
            con.Close();
        }

        public object ShowDataInGridView( string query)
        {
            //con.Open();
            SqlDataAdapter adapt = new SqlDataAdapter(query, con);
            DataTable dt = new DataTable();
            adapt.Fill(dt);
            //grid.DataSource = dt;
            //object dataum = dt.Tables[0];
            return dt;

        }
    }

}