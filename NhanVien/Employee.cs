using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;

namespace NhanVien
{
    public abstract class Employee
    {
        public string ssn { get; set; }
        public string firstName { get; set; }
        public string lastName { get; set; }
        public string birthDate { get; set; }
        public string phone { get; set; }
        public string email { get; set; }
        public int department { get; set; }
        public Employee(string ssn, string firstName, string lastName, string birthDate, string phone, string email,int department)
        {
            this.ssn = ssn;
            this.firstName = firstName;
            this.lastName = lastName;
            this.birthDate = birthDate;
            this.phone = phone;
            this.email = email;
            this.department = department;
        }
        public void GetInfor()
        {
            Console.WriteLine("SSN: " + this.ssn);
            Console.WriteLine("firstName: " + this.firstName);
            Console.WriteLine("lastName: " + this.lastName);
            Console.WriteLine("birthDate: " + this.birthDate);
            Console.WriteLine("phone: " + this.phone);
            Console.WriteLine("email: " + this.email);
            Console.WriteLine("department: " + this.department);
        }
        public void InputInfor(string SSN)
        {
            DataTable dt = GetData.GetFullDataFromSSN(SSN);
            DataRow dtRow = dt.Rows[0];
            ssn = dtRow["ssn"].ToString();
            firstName = dtRow["firstName"].ToString();
            lastName = dtRow["lastName"].ToString();
            birthDate = dtRow["birthDate"].ToString();
            phone = dtRow["phone"].ToString();
            email = dtRow["email"].ToString();
            department = (int)dtRow["department"];
        }
        public Employee()
        {

        }

    }


}
