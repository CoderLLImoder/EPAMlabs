using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    public class People
    {
        private Person first;
        private Person last;
        private Person current;

        public People()
        {
            first = null;
            last = null;
        }

        /// <summary>
        ///  который создаёт список людей в кругу 
        /// и делает его циклическим.
        /// </summary>
        public void PeopleAdd(int n)
        {
            if (first == null)
            {
                first = new Person(n);
                last = first;
            }
            else
            {
                last.next = new Person(n);
                last.next.previous = last;
                last = last.next;
                last.next = first;
                first.previous = last;
            }
            Print(n);
        }

        /// <summary>
        ///  Метод удаляющй каждого второго чловека в кругу.
        /// </summary>
        public void Count(int n)
        {
            current = first;
            Print(n);
            int k = n;
            
            for (int i = 1; i < n; i++)
            {
                    current.next = current.next.next;
                    current = current.next;
                    k--;
                    Print(k);
            }
        }

        /// <summary>
        ///  Метод вывода списка на экран.
        /// </summary>
        public int Print(int n)
        {
            Person p = current;
            for (int i = 1; i <= n; i++)
            {
                if (p != null)
                {
                    Console.Write(" {0} ", p.number);
                    if (i != n) p = p.next;
                }
            }
            Console.WriteLine();
            return 1;
        }
    }
}