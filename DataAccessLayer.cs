using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace Hospital1.DAL
{
    class DataAccessLayer
    {
        SqlConnection sqlconnection;
        //Initialize connection
        public DataAccessLayer()
        {
            sqlconnection = new SqlConnection(@"Server =. ; Database = Hospital ; Integrated Security = true" );
        }
        //Method to open connection

        public void Open()
        {
            if (sqlconnection.State != ConnectionState.Open)
            {
                sqlconnection.Open();
            }
        }

        //Method to close connection

        public void Close()
        {
            if (sqlconnection.State == ConnectionState.Open)
            {
                sqlconnection.Close();
            }
        }
        //Mehod to read data from database
        
        public DataTable SelectData (string stored_procedure , SqlParameter [] param)
        {
            SqlCommand sqlcmd = new SqlCommand();
            sqlcmd.CommandType = CommandType.StoredProcedure;
            sqlcmd.CommandText = stored_procedure;
            sqlcmd.Connection = sqlconnection;
            if (param != null)
            {
                for (int i = 0 ; i<param.Length ; i++)
                {
                    sqlcmd.Parameters.Add(param[i]);

                }
            }
            SqlDataAdapter da = new SqlDataAdapter(sqlcmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }

        //Method to insert , delete and update in database

        public void ExecuteCommand(string stored_procedure , SqlParameter [] param)
        {
            SqlCommand sqlcmd = new SqlCommand();
            sqlcmd.CommandType = CommandType.StoredProcedure;
            sqlcmd.CommandText = stored_procedure;
            sqlcmd.Connection = sqlconnection;

            if (param != null)
            {
                sqlcmd.Parameters.AddRange(param);
            }
            sqlcmd.ExecuteNonQuery();
        }
    
    }
  }
