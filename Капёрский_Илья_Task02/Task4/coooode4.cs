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
            const int n = 5;
            int Sum = 0;
            int[,] Arr = new int[n, n];
            Random rnd = new Random();
            Console.WriteLine("Исходный массив:");
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Arr[i, j] = rnd.Next(0, 9);
                    if ((i + j)%2==0) Sum += Arr[i, j];
                    Console.Write(" " + Arr[i, j]);
                }
                Console.WriteLine();
            }
            
            Console.WriteLine("Мумма чётных элементов =" + Sum);
            Console.Read();

        }
    }
}
