using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    public static class DataHelper
    {
        public static int Sum(this int[] a)
        {
            int sum = 0;
            for (int i = 0; i < a.Length; i++)
            {
                sum += a[i];
            }
            return sum;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            const int n = 10;
            int[] a = new int[n];
            Random rnd = new Random();
            Console.Write("Исходный массив:");
            for (int i = 0; i < n; i++)
            {
                a[i] = rnd.Next(-100, 100);
                Console.Write(" " + a[i]);
            }
            Console.WriteLine();

            Console.WriteLine("Сумма элементов массива = {0}", a.Sum());
            Console.ReadKey();
        }
    }
}
