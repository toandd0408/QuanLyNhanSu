using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;

namespace DAL
{
    class DBGetTable
    {
        public static bool fail = false;
        public static string failedStringCommand = "";
        public static DataTable GetTable(string stringcommand)
        {
            SqlConnection conn = DBConnect.Ketnoi();
            SqlCommand cmd = new SqlCommand(stringcommand, conn);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            try
            {
                da.Fill(dt);
            }
            catch
            {

                Debug.Write("\n Loi: stringcommand = " + stringcommand);
            }
            conn.Close();
            return dt;
        }
    }
}
