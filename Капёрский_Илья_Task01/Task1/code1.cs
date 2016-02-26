using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    class code1
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите длину стороны a=");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите длину стороны b=");
            int b = int.Parse(Console.ReadLine());
            if ((a >= 0) && (b >= 0))
            {
                int S = a * b;
                Console.WriteLine("Площадь прямоугольника S="+S);
            }
            else Console.WriteLine("Длины сторон должны быть положительными!");

            Console.Read();

        }
    }
}
