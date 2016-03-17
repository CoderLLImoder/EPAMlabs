using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    class program
    {
        static void Main(string[] args)
        {
            Office jhon = new Office("Джон");
            Office hugo = new Office("Хьюго");
            Office bill = new Office("Билл");

            Office.CameToWork(jhon);
            Office.CameToWork(hugo);
            Office.CameToWork(bill);
            Office.GoHome(jhon);
            Office.GoHome(hugo);
            Office.GoHome(bill);

            
            Console.ReadKey();
        }

        delegate void Message(string name);
    }
}
