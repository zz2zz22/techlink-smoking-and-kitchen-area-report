﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data.SqlClient;

namespace GetSmokingData_Techlink
{
    public class DatabaseSQLServerUtils
    {
        public static SqlConnection
                 GetDBConnection(string datasource, string database, string username, string password)
        {
            string connString = @"Data Source=" + datasource + ";Initial Catalog=" + database + ";Persist Security Info=True;User ID=" + username + ";Password=" + password;
            SqlConnection conn = new SqlConnection(connString);
            return conn;
        }
        public static SqlConnection
          GetHRDataConnection(string datasource, string database, string username, string password)
        {
            string connString = @"Data Source=" + datasource + ";Initial Catalog=" + database + ";Persist Security Info=True;User ID=" + username + ";Password=" + password;
            SqlConnection conn = new SqlConnection(connString);
            return conn;
        }
        public static SqlConnection
                 GetAttDBConnection(string datasource, string database, string username, string password)
        {
            string connString = @"Data Source=" + datasource + ";Initial Catalog=" + database + ";Persist Security Info=True;User ID=" + username + ";Password=" + password;
            SqlConnection conn = new SqlConnection(connString);
            return conn;
        }
    }
}
