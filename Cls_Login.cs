﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace Hospital1.BL
{
    class Cls_Login
    {
        public DataTable Login(string ID , string PWD)
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            SqlParameter[] param = new SqlParameter[2];
            param[0] = new SqlParameter("@ID", SqlDbType.NVarChar, 50);
            param[0].Value = ID;
            param[1] = new SqlParameter("@PWD", SqlDbType.NVarChar, 50);
            param[1].Value = PWD;

            DAL.Open();
            DataTable Dt = new DataTable();
            Dt = DAL.SelectData("Sp_Login ", param);
            DAL.Close();
             return Dt;
        }
    }
}
