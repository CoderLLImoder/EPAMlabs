using System;
using System.Linq;

namespace Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            int n;
            Console.WriteLine("Введите количество человек:");
            n = Convert.ToInt32(Console.ReadLine());
            if (n < 0)
            {
                Console.WriteLine("Число должно быть положительным");
                n = Convert.ToInt32(Console.ReadLine());
            }

            People P = new People();
            for (int i = 1; i <= n; i++)
            {
                P.PeopleAdd(i);
            }
            P.Count(n);

            Console.Write("Нажмите любую клавишу для закрытия программы.");
            Console.ReadKey();
        }
    }
}
