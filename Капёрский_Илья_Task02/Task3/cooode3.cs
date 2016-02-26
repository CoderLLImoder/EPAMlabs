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
            const int n = 10;
            int Sum = 0;
            int[] Arr = new int[n];
            Random rnd = new Random();
            Console.Write("Исходный массив:");
            for (int i = 0; i < n; i++)
            {
                Arr[i] = rnd.Next(-10, 10);
                if (Arr[i] > 0) Sum += Arr[i];
                Console.Write(" " + Arr[i]);
            }
            Console.WriteLine();
            Console.WriteLine("Сумма неотрицательных элементов= " + Sum);
            Console.Read();
        }
    }
}
