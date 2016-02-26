using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task6
{
    class coooooode6
    {
        static void Main(string[] args)
        {
            string[] str = {"", "", "" };
            string strtype = "";
            Console.WriteLine("Параметры надписи: None");
            do
            {
               int num;
                Console.WriteLine("1. bold");
                Console.WriteLine("2. italic");
                Console.WriteLine("3. underline");
                
                num = int.Parse(Console.ReadLine());
                switch (num)
                    {
                       case 1: strtype = "bold"; break;
                       case 2: strtype = "italic"; break;
                       case 3: strtype = "underline"; break;
                    }
                if (str[num-1] == "") str[num-1] = strtype;
                else str[num-1] = "";

                Console.Write("Параметры надписи: ");
                if (str[0] == "" && str[1] == "" && str[2] == "") Console.WriteLine("None");
                for (int i=0; i<3; i++)
                {
                    if (str[i] != "") Console.Write(str[i]+" ");
                }
                Console.WriteLine();
             }
          while (true);
           
        }
    }
}
