using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;

namespace GTL
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            #region ArrayList List
            ////Application.EnableVisualStyles();
            ////Application.SetCompatibleTextRenderingDefault(false);

            ////FormView view = new FormView();
            ////IList list = new ArrayList();
            ////FormController controller = new FormController(view, list);
            ////Application.Run(view);

            //ArrayList _list = new ArrayList();
            //_list.Add(new Student("Yeji", "Hwang", new DateTime(2000,5,26)));
            //_list.Add(new Person("Jisu", "Choi", new DateTime(2000,7,21)));
            //_list.Add(new Student("Ryujin", "Shin", new DateTime(2001,4,17)));
            //_list.Add(new Person("Chaeryeong", "Lee", new DateTime(2001, 6, 5)));
            //_list.Add(new Person("Yuna", "Shin", new DateTime(2003, 12, 9)));

            //foreach (Person p in _list)
            //{
            //    Console.WriteLine($"{p.ToString()}\n");
            //}

            //List<Person> _plist = new List<Person>();
            //_plist.Add(new Employee(new Person("Karl", "Noval", new DateTime(1993, 6, 6)), "Ateneo de Cebu", new DateTime(2019, 4, 22)));
            //_plist.Add(new Employee(new Person("Lea", "Mijares", new DateTime(1998, 10, 21)), "Ateneo de Cebu", new DateTime(2019, 4, 22)));
            //_plist.Add(new Person("Donna", "Yue", new DateTime(1990, 1, 30)));
            //_plist.Add(new Student("Ram", "Alarcon", new DateTime(2003, 12, 5)));

            //foreach (Person p in _plist)
            //{
            //    Console.WriteLine($"{p.ToString()}\n");
            //}

            //Console.WriteLine(_list.IsReadOnly);

            //// initializing a read only arraylist
            //ArrayList _mlist = ArrayList.ReadOnly(_list);

            //// initializing a read only List (any read only Generic)
            //ReadOnlyCollection<Person> _xlist = _plist.AsReadOnly();

            //foreach(Person p in _mlist)
            //{
            //    if (p is Student)
            //    {
            //        try
            //        {
            //            _mlist.Remove(p);
            //        }catch(Exception e)
            //        {
            //            Console.WriteLine(e.Message);
            //        }
            //    }else
            //    {
            //        Console.WriteLine($"{p.ToString()}\n");
            //    }
            //}

            //Console.WriteLine($"{_mlist.Count}\n");

            #endregion

            #region LINQ

            int[] scores = new int[] { 97, 92, 82, 60 };

            IEnumerable<int> scoreQuery = from score in scores where score > 80 select score;

            foreach (int i in scoreQuery)
            {
                Console.Write(i + " ");
            }

            #endregion

            Console.ReadKey();
        }

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
}
