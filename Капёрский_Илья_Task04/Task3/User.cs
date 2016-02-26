using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    class User
    {
        private string Name;
        public void setName(string s)
        {
            Name = s;
        }
        public string getName()
        {
            return(Name);
        }

        private string Surname;
        public void setSurname(string s)
        {
            Surname = s;
        }
        public string getSurname()
        {
            return(Surname);
        }

        private string SecondName;
        public void setSecondName(string s)
        {
            SecondName = s;
        }
        public string getSecondName()
        {
            return (SecondName);
        }

        private int Age;
        public void setAge(int value)
        {
            Age=value;
        }
        public int getAge()
        {
            return(Age);
        }

        private string Birthday;
        public void setBirthday(string s)
        {
            Birthday = s;
        }
        public string getBirthday()
        {
            return Birthday;
        }

        public void Print()
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
        }


    }
}
