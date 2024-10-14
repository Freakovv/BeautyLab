using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using Microsoft.Data.SqlClient;

namespace BeautyLab
{
    internal class DataBase
    {
        private readonly SqlConnection con =
            new SqlConnection(
                @"Data Source=DESKTOP-16N2RPD\FREAKOVVSERVER;Initial Catalog=BeautyLab; Integrated Security=True");

        public void OpenConnection()
        {
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
        }

        public void CloseConnection()
        {
            if (con.State == ConnectionState.Open)
            {
                con.Close();
            }
        }

        public SqlConnection GetConnection()
        {
            return con;
        }
    }
}
