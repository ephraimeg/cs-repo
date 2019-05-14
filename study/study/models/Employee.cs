using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GTL
{
    public class Employee : Person
    {
        public string Company { get; }
        public DateTime EmploymentDate { get; }
        public double RatePerHour { get; }

        public Employee(Person person, string company, DateTime employmentdate) : base(person.FirstName, person.LastName, person.BirthDate)
        {
            Company = company;
            EmploymentDate = employmentdate;
        }

        public override string ToString()
        {
            return string.Concat(base.ToString(), $"\nCompany:\t {this.Company}\nEmployee Since:\t {this.EmploymentDate.ToString("MM/dd/yyyy")}");
        }

    }
}
