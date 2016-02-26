using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    public class Line
    {
        public int x1, x2;
        public int y1, y2;
                
        public Line(){ }

        public void get(int X1, int X2, int Y1, int Y2)
        {
            x1 = X1;
            x2 = X2;
            y1 = Y1;
            y2 = Y2;
        }

        public void Show()
        {
            Console.WriteLine("Тип: Линия. Координаты: начальная точка({0};{1}), конечная точка({2};{3})",x1, y1, x2, y2);
        }
    }
}
