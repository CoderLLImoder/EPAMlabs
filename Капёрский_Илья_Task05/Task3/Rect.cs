using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    class Rect
    {
        public Line line1 = new Line();
        public Line line2 = new Line();

        public Rect() { }
        public void get(int X1, int Y1, int X2, int Y2, int X3, int Y3, int X4, int Y4)
        {
            line1.x1 = X1;
            line1.y1 = Y1;
            line1.x2 = X2;
            line1.y2 = Y2;
            line2.x1 = X3;
            line2.y1 = Y3;
            line2.x2 = X4;
            line2.y2 = Y4;
        }

        public void Show()
        {
            Console.WriteLine("Тип: Прямоугольник.Координаты: A({0};{1}), B({2};{3}), C({4};{5}), D({6};{7})",
                line1.x1, line1.y1, line1.x2, line1.y2, line2.x1, line2.y1, line2.x2, line2.y2);
        }
    }
}
