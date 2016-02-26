using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    class coode2
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите первую строку:");
            StringBuilder s1 = new StringBuilder( Console.ReadLine());
            Console.WriteLine("Введите вторую строку:");
            StringBuilder s2 = new StringBuilder(Console.ReadLine());

            
            int n = s1.Length;
            for (int i = n-1; i >=0; i--)
            {
                for (int j = 0; j < s2.Length; j++)
                {                             
                    if (s1[i] == s2[j])
                    {
                        s1.Insert(i, s1[i]);
                    }                       
                }
            }
                       
            Console.WriteLine(s1);
            Console.ReadLine();
        }
    }
}
