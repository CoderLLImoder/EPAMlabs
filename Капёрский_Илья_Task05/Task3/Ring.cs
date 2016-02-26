using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    public class Ring
    {
        public Round IN = new Round();
        public Round OUT = new Round();

        public Ring() { }
        public void get(int X, int Y, int Rin, int Rout)
        {
            IN.x = X;
            IN.y = Y;
            IN.r = Rin;

            OUT.x = X;
            OUT.y = Y;
            OUT.r = Rout;
        }

        public void Show()
        {
            Console.WriteLine("Тип: Кольцо. Координаты центра({0};{1}), внешний радиус {2}, внутренний радиус {3}",
                IN.x, IN.y, IN.r, OUT.r);
        }
    }
}
