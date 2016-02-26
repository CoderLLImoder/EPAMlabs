using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    public class Round : Circle
    {
       public Round() { }
       public new void get(int X, int Y, int R)
        {
            x = X;
            y = Y;
            r = R;
        }
        public new void Show()
        {
            Console.WriteLine("Тип: Круг. Координаты центра({0};{1}), радиус {2}", x, y, r);
        }
    }
}
