using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    public class Circle
    {
        public int x;
        public int y;
        public int r;
        public Circle() { }
        public void get(int X, int Y, int R)
        {
            x = X;
            y = Y;
            r = R;
        }
        public void Show()
        {
            Console.WriteLine("Тип: Окружность. Координаты центра({0};{1}), радиус {2}", x, y, r);
        }
    }
}
