using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GTL
{
    public class Person : IComparable
    {
        public string FirstName { get; }
        public string LastName { get; }
        public string FullName { get; }
        public DateTime BirthDate { get; }
        public short Age
        {
            get
            {
                DateTime today = DateTime.Now;

                if (today.Month < BirthDate.Month && today.Day < BirthDate.Day)
                    today = today.AddYears(-1);

                return Convert.ToInt16(today.Year - BirthDate.Year);
            }
        }
        public Person(string firstname, string lastname, DateTime birthdate)
        {
            FirstName = firstname;
            LastName = lastname;
            FullName = String.Format($"{lastname}, {firstname}");
            BirthDate = birthdate;
        }

        public override string ToString()
        {
            return $"First Name:\t {this.FirstName}\nLast Name:\t {this.LastName}\nAge:\t\t {this.Age}";
        }

        public int CompareTo(object obj)
        {
            return LastName.CompareTo(((Person)obj).LastName);
        }
    }
}
