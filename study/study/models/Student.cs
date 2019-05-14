using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GTL
{
    public class Student : Person
    {
        private static int _id = 1;
        public string ID { get; }
        public Student(string firstname, string lastname, DateTime birthdate) : base(firstname, lastname, birthdate)
        {
            ID = string.Format("{0:00000}", _id++);
        }
        public override string ToString()
        {
            return String.Concat($"Student ID:\t {this.ID}\n", base.ToString());
        }
    }
}
