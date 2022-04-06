using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
            Console.WriteLine("SSN: " + this.ssn);
            Console.WriteLine("firstName: " + this.firstName);
            Console.WriteLine("lastName " + this.lastName);
            Console.WriteLine("birthDate " + this.birthDate);
            Console.WriteLine("phone " + this.phone);
            Console.WriteLine("email " + this.email);
            Console.WriteLine("department " + this.department);
            Console.WriteLine("commissionRate " + this.rate);
            Console.WriteLine("grossSales " + this.workingHours);
            Console.WriteLine("luong " + this.Salary);
        }
    }
}
