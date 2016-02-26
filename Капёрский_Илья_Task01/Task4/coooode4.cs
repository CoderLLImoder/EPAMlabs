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
            Console.Write("Введите количество строк N=");
            int n = int.Parse(Console.ReadLine());
            
            for (int m = 1; m <= n; m++)
            {
                int max = 2 * m - 1;
                for (int i = m - 1; i >= 0; i--)
                {
                    int space =i+n-m;
                    while (space > 0)
                    {
                        Console.Write(" ");
                        space--;
                    }
                    

                    int j = 2 * i;
                    while (max - j > 0)
                    {
                        Console.Write("*");
                        j++;
                    }

                    Console.WriteLine("");
                }
                
            }
            Console.Read();
        }
    }
}
