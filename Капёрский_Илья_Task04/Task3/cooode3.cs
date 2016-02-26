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
            var user1 = new User();
            Console.WriteLine("Введите Имя:");
            user1.setName(Console.ReadLine());

            Console.WriteLine("Введите Фамилию:");
            user1.setSurname(Console.ReadLine());

            Console.WriteLine("Введите Отчество:");
            user1.setSecondName(Console.ReadLine());

            Console.WriteLine("Введите Возраст:");
            user1.setAge(int.Parse(Console.ReadLine()));

            Console.WriteLine("Введите Дату рождения:");
            user1.setBirthday(Console.ReadLine());

            user1.Print();
            
            Console.WriteLine("Изменить: ");
            do
            {
                int num;
                Console.WriteLine("1. Имя.");
                Console.WriteLine("2. Фамилию.");
                Console.WriteLine("3. Отчество.");
                Console.WriteLine("4. Возраст.");
                Console.WriteLine("5. Дату рождения.");
                num = int.Parse(Console.ReadLine());
                switch (num)
                {
                    case 1:
                        Console.WriteLine("Введите имя:");
                        user1.setName(Console.ReadLine());
                        user1.Print();
                        break;
                    case 2:
                        Console.WriteLine("Введите Фамилию:");
                        user1.setSurname(Console.ReadLine());
                        user1.Print();
                        break;
                    case 3:
                        Console.WriteLine("Введите Отчество:");
                        user1.setSecondName(Console.ReadLine());
                        user1.Print();
                        break;
                    case 4:
                        Console.WriteLine("Введите Возраст:");
                        user1.setAge(int.Parse(Console.ReadLine()));
                        user1.Print();
                        break;
                    case 5:
                        Console.WriteLine("Введите Дату рождения:");
                        user1.setBirthday(Console.ReadLine());
                        user1.Print();
                        break;
                } 
            } while (true);

        }
    }
}
