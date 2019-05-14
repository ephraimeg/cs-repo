using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GTL.MArrayList
{
    public class MArrayList
    {
        public void Main()
        {
            ArrayList _list = new ArrayList();
            _list.Add(new Student("Yeji", "Hwang", new DateTime(2000, 5, 26)));
            _list.Add(new Person("Jisu", "Choi", new DateTime(2000, 7, 21)));
            _list.Add(new Student("Ryujin", "Shin", new DateTime(2001, 4, 17)));
            _list.Add(new Person("Chaeryeong", "Lee", new DateTime(2001, 6, 5)));
            _list.Add(new Person("Yuna", "Shin", new DateTime(2003, 12, 9)));

            foreach (Person p in _list)
            {
                Console.WriteLine($"{p.ToString()}\n");
            }

            Console.WriteLine(_list.IsReadOnly);

            // initializing a read only arraylist
            ArrayList _mlist = ArrayList.ReadOnly(_list);

            foreach (Person p in _mlist)
            {
                if (p is Student)
                {
                    try
                    {
                        _mlist.Remove(p);
                    }
                    catch (Exception e)
                    {
                        Console.WriteLine(e.Message);
                    }
                }
                else
                {
                    Console.WriteLine($"{p.ToString()}\n");
                }
            }

            Console.WriteLine($"{_mlist.Count}\n");

        }
    }
}
