using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    public class Employee : User
    {
        private double exp;
        public void setExp(double value)
        {
           exp = value;
        }
        public double getExp()
        {
            return (exp);
        }

        private string job;
        public void setJob(string s)
        {
            job = s;
        }
        public string getJob()
        {
            return (job);
        }

        public void  Print()
        {
            Console.Write("Имя: ");
            Console.WriteLine(getName());

            Console.Write("Отчество: ");
            Console.WriteLine(getSecondName());

            Console.Write("Фамилия: ");
            Console.WriteLine(getSurname());

            Console.Write("Возраст: ");
            Console.WriteLine(getAge());

            Console.Write("Дата рождения: ");
            Console.WriteLine(getBirthday());

            Console.Write("Опыт работы: ");
            Console.WriteLine(getExp());

            Console.Write("Должность: ");
            Console.WriteLine(getJob());
        }
    }
}
