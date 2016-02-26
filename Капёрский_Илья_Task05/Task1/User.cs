using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    public class User
    {

        protected string Name;
        public void setName(string s)
        {
            Name = s;
        }
        public string getName()
        {
            return (Name);
        }

        protected string Surname;
        public void setSurname(string s)
        {
            Surname = s;
        }
        public string getSurname()
        {
            return (Surname);
        }

        protected string SecondName;
        public void setSecondName(string s)
        {
            SecondName = s;
        }
        public string getSecondName()
        {
            return (SecondName);
        }

        protected double Age;
        public void setAge(double value)
        {
            Age = value;
        }
        public double getAge()
        {
            return (Age);
        }

        protected string Birthday;
        public void setBirthday(string s)
        {
            Birthday = s;
        }
        public string getBirthday()
        {
            return Birthday;
        }

        
    }
}
