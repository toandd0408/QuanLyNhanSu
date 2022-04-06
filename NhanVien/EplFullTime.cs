using System;

namespace NhanVien
{
    public class EplFullTime: Employee
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
            this.Salary = comRate*grossSales/100+basicSalary;
        }
        public void GetinfoFullTime()
        {
            Console.WriteLine("SSN: " + this.ssn);
            Console.WriteLine("firstName: " + this.firstName);
            Console.WriteLine("lastName " + this.lastName);
            Console.WriteLine("birthDate " + this.birthDate);
            Console.WriteLine("phone " + this.phone);
            Console.WriteLine("email " + this.email);
            Console.WriteLine("department " + this.department);
            Console.WriteLine("commissionRate " + this.comRate);
            Console.WriteLine("grossSales " + this.grossSales);
            Console.WriteLine("basicSalary " + this.basicSalary);
            Console.WriteLine("luong " + this.Salary);
        }
    }
}
