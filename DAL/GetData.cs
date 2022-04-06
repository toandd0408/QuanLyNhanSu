using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;


namespace DAL
{
    public class GetData
    {
        public static DataTable GetFullDataEmployee()
        {
            DataTable dt = DBGetTable.GetTable("Select * from infoEmployee");
            return dt;
        }
        public static DataTable GetFullDataFromName(string name)
        {
            DataTable dt = DBGetTable.GetTable("select * from infoEmployee where fullName = '" + name + "'");
            return dt;
        }
        public static DataTable GetFullDataFromSSN(string ssn)
        {
            DataTable dt = DBGetTable.GetTable("select *from infoEmployee where ssn = '" + ssn + "'");
            return dt;
        }
        public static DataTable GetSalaryFullTimeFromSSN(string ssn)
        {
            DataTable dt = DBGetTable.GetTable("select *from fullTimeEmp where ssn = '" + ssn + "'");
            return dt;
        }
        public static DataTable GetSalaryPartTimeFromSSN(string ssn)
        {
            DataTable dt = DBGetTable.GetTable("select *from partTimeEmp where ssn = '" + ssn + "'");
            return dt;
        }
        public static DataTable GetSSNFromName(string name)
        {
            DataTable dt = DBGetTable.GetTable("select ssn from infoEmployee where fullName = '" + name + "'");
            return dt;
        }
        public static DataTable GetSSNandNameFromDePart(int depart)
        {
            DataTable dt = DBGetTable.GetTable("select ssn, fullName from infoEmployee where department= '" + depart + "'");
            return dt;
        }
        //Lay cac phong ban
        public static DataTable GetDePart()
        {
            DataTable dt = DBGetTable.GetTable("select distinct department from infoEmployee");
            return dt;
        }
        //Dem so nguoi trong 1 van phong
        public static DataTable CountMemberInDeP(int deP)
        {
            DataTable dt = DBGetTable.GetTable("select count (ssn) as SoNguoi from infoEmployee where department = '" + deP + "'");
            return dt;
        }

    }
}
