using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    class cooode3
    {
        static void Main(string[] args)
        {
            var line = new Line();
            var circle = new Circle();
            var round = new Round();
            var ring = new Ring();
            var rect = new Rect();
            bool li = false, ci = false, ro = false, ri = false, re = false;
            do
            {
                int num;
               
                Console.WriteLine("1. Добавить линию.");
                Console.WriteLine("2. Добавить окружность.");
                Console.WriteLine("3. Добавить круг.");
                Console.WriteLine("4. Добавить кольцо.");
                Console.WriteLine("5. Добавить прямоугольник.");
                Console.WriteLine("6. Вывести на экран все фигуры.");
                num = int.Parse(Console.ReadLine());
                switch (num)
                {
                    case 1:
                        Console.WriteLine("Введите координаты первой точки:");
                        Console.WriteLine("x=");
                        int X1 = int.Parse(Console.ReadLine());
                        Console.WriteLine("y=");
                        int Y1 = int.Parse(Console.ReadLine());

                        Console.WriteLine("Введите координаты второй точки:");
                        Console.WriteLine("x=");
                        int X2 = int.Parse(Console.ReadLine());
                        Console.WriteLine("y=");
                        int Y2 = int.Parse(Console.ReadLine());

                        line.get(X1, Y1, X2, Y2);
                        li = true;
                        break;

                    case 2:
                        Console.WriteLine("Введите координаты центра и радиус:");
                        Console.WriteLine("x=");
                        int X = int.Parse(Console.ReadLine());
                        Console.WriteLine("y=");
                        int Y = int.Parse(Console.ReadLine());
                        Console.WriteLine("r=");
                        int R = int.Parse(Console.ReadLine());
                        circle.get(X, Y, R);
                        ci = true;
                        break;

                    case 3:
                        Console.WriteLine("Введите координаты центра и радиус:");
                        Console.WriteLine("x=");
                        int Xro = int.Parse(Console.ReadLine());
                        Console.WriteLine("y=");
                        int Yro = int.Parse(Console.ReadLine());
                        Console.WriteLine("r=");
                        int Rro = int.Parse(Console.ReadLine());
                        round.get(Xro, Yro, Rro);
                        ro = true;
                        break;

                    case 4:
                        Console.WriteLine("Введите координаты центра:");
                        Console.WriteLine("x=");
                        int Xri = int.Parse(Console.ReadLine());
                        Console.WriteLine("y=");
                        int Yri = int.Parse(Console.ReadLine());
                        Console.WriteLine("Введите внеший радиус R=");
                        int Rri = int.Parse(Console.ReadLine());
                        Console.WriteLine("Введите внутренный радиус r=");
                        int rri = int.Parse(Console.ReadLine());
                        ri = true;
                        ring.get(Xri, Yri, Rri, rri);
                        break;

                    case 5:
                        Console.WriteLine("Введите координаты первой точки:");
                        Console.WriteLine("x=");
                        int x1 = int.Parse(Console.ReadLine());
                        Console.WriteLine("y=");
                        int y1 = int.Parse(Console.ReadLine());

                        Console.WriteLine("Введите координаты второй точки:");
                        Console.WriteLine("x=");
                        int x2 = int.Parse(Console.ReadLine());
                        Console.WriteLine("y=");
                        int y2 = int.Parse(Console.ReadLine());

                        Console.WriteLine("Введите координаты третьей точки:");
                        Console.WriteLine("x=");
                        int x3 = int.Parse(Console.ReadLine());
                        Console.WriteLine("y=");
                        int y3 = int.Parse(Console.ReadLine());

                        Console.WriteLine("Введите координаты четвертой точки:");
                        Console.WriteLine("x=");
                        int x4 = int.Parse(Console.ReadLine());
                        Console.WriteLine("y=");
                        int y4 = int.Parse(Console.ReadLine());

                        rect.get(x1, y2, x2, y2, x3, y3, x4, y4);
                        re = true;
                        break;

                    case 6:
                        if (li) line.Show();                        
                        if (ci) circle.Show();
                        if (ro) round.Show();
                        if (ri) ring.Show();
                        if (re) rect.Show();
                        break;

                }
            } while (true);
        }
    }
}
