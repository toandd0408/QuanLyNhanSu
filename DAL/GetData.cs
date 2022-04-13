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
        //Lay thong tin cua nhan vien
        public static DataTable GetFullDataEmployee()
        {
            DataTable dt = DBGetTable.GetTable("Select * from infoEmployee");
            return dt;
        }
        //Lay thong tin cua 1 nguoi tu ten nguoi do
        public static DataTable GetFullDataFromName(string name)
        {
            DataTable dt = DBGetTable.GetTable("select * from infoEmployee where fullName = '" + name + "'");
            return dt;
        }
        //Lay thong tin cua 1 nguoi tu ssn cua nguoi do
        public static DataTable GetFullDataFromSSN(string ssn)
        {
            DataTable dt = DBGetTable.GetTable("select *from infoEmployee where ssn = '" + ssn + "'");
            return dt;
        }
        //Lay thong tin ve Salary theo SSN
        public static DataTable GetSalaryFullTimeFromSSN(string ssn)
        {
            DataTable dt = DBGetTable.GetTable("select *from fullTimeEmp where ssn = '" + ssn + "'");
            return dt;
        }
        //Lay thong tin luong theo SSN
        public static DataTable GetSalaryPartTimeFromSSN(string ssn)
        {
            DataTable dt = DBGetTable.GetTable("select *from partTimeEmp where ssn = '" + ssn + "'");
            return dt;
        }
        //Lay SSN tu ten
        public static DataTable GetSSNFromName(string name)
        {
            DataTable dt = DBGetTable.GetTable("select ssn from infoEmployee where fullName = '" + name + "'");
            return dt;
        }
        //Lay SSN va ten cua nhung nguoi cua 1 phong ban nao do 
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
        //Lay ssn tu ten
        public static string GetSSNFromFName(string name)
        {
            DataTable dtA = GetData.GetSSNFromName(name);
            DataRow dtARow = dtA.Rows[0];
            var ssn = dtARow["ssn"].ToString();
            return ssn;
        }

    }
}
