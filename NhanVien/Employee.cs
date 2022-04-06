using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
    }

}
