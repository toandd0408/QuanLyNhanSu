using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using DAL;

namespace NhanVien
{
    public class EplPartTime : Employee
    {
        public int rate { get; set; }
        public int workingHours { get; set; }
        public int Salary;
        public EplPartTime(string ssn, string firstName, string lastName, string birthDate, string phone, string email, int department, int rate, int workingHours) : base (ssn, firstName, lastName, birthDate, phone, email, department) 
        {
            this.rate = rate;
            this.workingHours = workingHours;
            this.Salary = rate * workingHours;
        }  
        public void GetinfoPartTime()
        {
            GetInfor();
            Console.WriteLine("Rate: " + this.rate);
            Console.WriteLine("WorkingHours: " + this.workingHours);
            Console.WriteLine("luong: " + this.Salary);
        }
        public void InputSalaryPartTime(string SSN)
        {
            DataTable dt1 = GetData.GetSalaryPartTimeFromSSN(SSN);
            DataRow dt1Row = dt1.Rows[0];
            rate = (int)dt1Row["rate"];
            workingHours = (int)dt1Row["workingHours"];           
            Salary = rate * workingHours;

        }
        public EplPartTime()
        {

        }
    }
}
