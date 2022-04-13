using System;
using System.Data;
using DAL;

namespace NhanVien
{
    public class EplFullTime : Employee
    {
        public int comRate { get; set; }
        public int grossSales { get; set; }
        public int basicSalary { get; set; }
        public int Salary;
        public EplFullTime(string ssn, string firstName, string lastName, string birthDate, string phone, string email, int department, int comRate, int grossSales, int basicSalary) : base(ssn, firstName, lastName, birthDate, phone, email, department)
        {
            this.comRate = comRate;
            this.grossSales = grossSales;
            this.basicSalary = basicSalary;
            this.Salary = comRate * grossSales / 100 + basicSalary;
        }

        public void GetinfoFullTime()
        {
            GetInfor();
            Console.WriteLine("commissionRate: " + this.comRate);
            Console.WriteLine("grossSales: " + this.grossSales);
            Console.WriteLine("basicSalary: " + this.basicSalary);
            Console.WriteLine("luong: " + this.Salary);
        }
        public void InputSalaryFullTime(string SSN)
        {
            DataTable dt = GetData.GetSalaryFullTimeFromSSN(SSN);
            DataRow dtRow = dt.Rows[0];
            comRate = (int)dtRow["commissionRate"];
            grossSales = (int)dtRow["grossSales"];
            basicSalary = (int)dtRow["basicSalary"];
            Salary = comRate * grossSales / 100 + basicSalary;

        }
        public EplFullTime()
        {

        }
    }
}
