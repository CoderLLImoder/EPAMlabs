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
            Console.Write("Введите количество строк N=");
            int n = int.Parse(Console.ReadLine());
            for (int i = n-1; i >= 0; i--)
            {
                int j = i;
                while (n - j > 0)
                {
                    Console.Write("*");
                    j++;
                }
                Console.WriteLine("");
            }
            Console.Read();
        }
    }
}
