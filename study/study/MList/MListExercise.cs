using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GTL.List
{
    public class MListExercise
    {
        public void Main()
        {
            List<Person> _plist = new List<Person>();
            _plist.Add(new Employee(new Person("Karl", "Noval", new DateTime(1993, 6, 6)), "Ateneo de Cebu", new DateTime(2019, 4, 22)));
            _plist.Add(new Employee(new Person("Lea", "Mijares", new DateTime(1998, 10, 21)), "Ateneo de Cebu", new DateTime(2019, 4, 22)));
            _plist.Add(new Person("Donna", "Yue", new DateTime(1990, 1, 30)));
            _plist.Add(new Student("Ram", "Alarcon", new DateTime(2003, 12, 5)));

            foreach (Person p in _plist)
            {
                Console.WriteLine($"{p.ToString()}\n");
            }

            // initializing a read only List (any read only Generic)
            System.Collections.ObjectModel.ReadOnlyCollection<Person> _xlist = _plist.AsReadOnly();

            Console.WriteLine(_xlist);
        }
    }
}
