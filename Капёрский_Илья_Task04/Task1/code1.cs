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
            var round = new Round();
            Console.WriteLine("Выберите действие с кругом: ");
            do
            {
                int num; double value;
                Console.WriteLine("1. Задать координаты и радиус.");
                Console.WriteLine("2. Вычислить длину окружности.");
                Console.WriteLine("3. Вычислить площадь круга.");
                num = int.Parse(Console.ReadLine());
                switch (num)
                {
                    case 1:
                        Console.WriteLine("Введите х=");
                        round.setx(double.Parse(Console.ReadLine()));

                        Console.WriteLine("Введите y=");
                        round.sety(double.Parse(Console.ReadLine()));

                        do
                        {
                            Console.WriteLine("Введите неотрицательное значение r=");
                            value = double.Parse(Console.ReadLine());
                        } while (value < 0);
                        round.setr(value);

                        break;
                    case 2:
                        Console.WriteLine("Длина окружности L=" + round.Length());
                        break;
                    case 3:
                        Console.WriteLine("Площадь круга S=" + round.Square());
                        break;
                }
            } while (true);
        }
    }
}
