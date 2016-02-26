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
            Console.WriteLine("Напишите строку:");

            string str = Console.ReadLine();
            char[] div = { ' ', ',', '.', '-', '!', '"', '?', '(', ')' }; //создаем массив разделителей
            string[] parts = str.Split(div);                            // Разбиваем строку на части
            int CharSum = 0;
            int num = 0;
            for (int i = 0; i < parts.Length; i++)
            {
                if (parts[i] != "")
                {
                    CharSum += parts[i].Length;
                    num++;
                }
            }
            double Average = (double)CharSum / (double)num;
            Console.WriteLine("Средняя длина слова в строке: " + Average);
            Console.Read();
        }
    }
}
