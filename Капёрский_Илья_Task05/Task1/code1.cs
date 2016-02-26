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
            var empl = new Employee();
            Console.WriteLine("Введите Имя:");
            empl.setName(Console.ReadLine());

            Console.WriteLine("Введите Фамилию:");
            empl.setSurname(Console.ReadLine());

            Console.WriteLine("Введите Отчество:");
            empl.setSecondName(Console.ReadLine());

            Console.WriteLine("Введите Возраст:");
            empl.setAge(int.Parse(Console.ReadLine()));

            Console.WriteLine("Введите Дату рождения:");
            empl.setBirthday(Console.ReadLine());

            Console.WriteLine("Введите Опыт работы:");
            empl.setExp(int.Parse(Console.ReadLine()));
            

            Console.WriteLine("Введите Должность:");
            empl.setJob(Console.ReadLine());
            empl.Print();
            Console.WriteLine("Изменить: ");
            do
            {
                int num;
                Console.WriteLine("1. Имя.");
                Console.WriteLine("2. Фамилию.");
                Console.WriteLine("3. Отчество.");
                Console.WriteLine("4. Возраст.");
                Console.WriteLine("5. Дату рождения.");
                Console.WriteLine("6. Опыт работы.");
                Console.WriteLine("7. Должность.");
                num = int.Parse(Console.ReadLine());
                switch (num)
                {
                    case 1:
                        Console.WriteLine("Введите имя:");
                        empl.setName(Console.ReadLine());
                        empl.Print();
                        break;
                    case 2:
                        Console.WriteLine("Введите Фамилию:");
                        empl.setSurname(Console.ReadLine());
                        empl.Print();
                        break;
                    case 3:
                        Console.WriteLine("Введите Отчество:");
                        empl.setSecondName(Console.ReadLine());
                        empl.Print();
                        break;
                    case 4:
                        Console.WriteLine("Введите Возраст:");
                        empl.setAge(int.Parse(Console.ReadLine()));
                        empl.Print();
                        break;
                    case 5:
                        Console.WriteLine("Введите Дату рождения:");
                        empl.setBirthday(Console.ReadLine());
                        empl.Print();
                        break;
                    case 6:
                        Console.WriteLine("Введите Опыт работы:");
                        empl.setExp(int.Parse(Console.ReadLine()));
                        empl.Print();
                        break;
                    case 7:
                        Console.WriteLine("Введите Должность:");
                        empl.setJob(Console.ReadLine());
                        empl.Print();
                        break;
                }
            } while (true);
        }
    }
}
