using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    class cooode3
    {
        static void Main(string[] args)
        {
            Console.Write("Введите количество строк N=");              
            int n = int.Parse(Console.ReadLine());                     
            int max = 2 * n - 1;                                       
            for (int i = n-1; i >= 0; i--)
            {
                int space = i;
                while (space > 0)
                {
                    Console.Write(" ");
                    space--;
                }

                int j = 2*i;
                while (max-j>0)
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
