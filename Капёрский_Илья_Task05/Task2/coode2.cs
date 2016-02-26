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
            Console.WriteLine("Введите внутренний радиус кольца: ");
            int Rin=int.Parse(Console.ReadLine());
            Console.WriteLine("Введите внешний радиус кольца: ");
            int Rout = int.Parse(Console.ReadLine());

            var ring = new Ring(Rin, Rout);
            double area=ring.GetArea();
            double length=ring.GetLength();

            Console.WriteLine("Площадь кольца = {0}, сумма длин окружностей ={1}", area, length);
            Console.Read();
        }
    }
}
