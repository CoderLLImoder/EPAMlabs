using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    public static class DataHelper
    {
        /// <summary>
        /// Расширяющий метод, проверяет строку на положительное число.
        /// </summary>

        public static bool StringToInt(this string s)
        {
            bool c = true;
            for (int i = 0; i < s.Length; i++)
            {
                if (s == "") { Console.WriteLine("Строка является пустой"); }
                else
                {
                    if ((s[i] != '0') && (s[i] != '1') && (s[i] != '2') && (s[i] != '3') && (s[i] != '4') && (s[i] != '5') && (s[i] != '6') && (s[i] != '7') && (s[i] != '8') && (s[i] != '9'))
                        c = false;
                }

            }
            return c;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
                Console.WriteLine("Введите строку:");
                string str = Console.ReadLine();
                bool Z = str.StringToInt();
                if (Z) Console.WriteLine("Строка является положительным целым числом.");
                else Console.WriteLine("Строка не является положительным целым числом.");
                Console.ReadKey();
         }
    }
}
