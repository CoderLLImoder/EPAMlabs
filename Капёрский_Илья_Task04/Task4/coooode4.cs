using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4
{
    class coooode4
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите строку1:");
            string s1 = Console.ReadLine();
            Console.WriteLine("Введите строку2:");
            string s2 = Console.ReadLine();
            var MyStr1 = new Mystring();
            var MyStr2 = new Mystring();
            var MyStr3 = new Mystring();

            MyStr1.set(s1);
            MyStr1.show();
            
            MyStr2.set(s2);
            MyStr2.show();

            MyStr3 = MyStr1 + MyStr2;
            MyStr3.show();

            Console.Read();
            
        }
    }
}
