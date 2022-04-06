using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;


namespace DAL
{
    class DBConnect
    {
        public static SqlConnection Ketnoi()
        {
            string strConnection = @"Data Source=DUONGTOAN;Initial Catalog=salary;Integrated Security=True";

            SqlConnection conn = new SqlConnection(strConnection);
            return conn;
        }
    }
}
