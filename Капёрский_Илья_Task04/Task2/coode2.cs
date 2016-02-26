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
            var abc = new ABC();
            Console.WriteLine("Выберите действие с треугольником: ");
            do
            {
                int num; double x; double y;
                Console.WriteLine("1. Задать координаты.");
                Console.WriteLine("2. Вычислить периметр.");
                Console.WriteLine("3. Вычислить площадь.");
                num = int.Parse(Console.ReadLine());
                switch (num)
                {
                    case 1:
                        Console.WriteLine("Введите координаты точки а");
                        Console.WriteLine("x=");
                        x = double.Parse(Console.ReadLine());
                        Console.WriteLine("y=");
                        y = double.Parse(Console.ReadLine());
                        abc.seta(x, y);

                        Console.WriteLine("Введите координаты точки b");
                        Console.WriteLine("x=");
                        x = double.Parse(Console.ReadLine());
                        Console.WriteLine("y=");
                        y = double.Parse(Console.ReadLine());
                        abc.setb(x, y);

                        Console.WriteLine("Введите координаты точки c");
                        Console.WriteLine("x=");
                        x = double.Parse(Console.ReadLine());
                        Console.WriteLine("y=");
                        y = double.Parse(Console.ReadLine());
                        abc.setc(x, y);

                        break;
                    case 2:
                        Console.WriteLine("Периметр P=" + abc.P());
                        break;
                    case 3:
                        Console.WriteLine("Площадь S=" + abc.S());
                        break;
                }
            } while (true);
        }
    }
}
