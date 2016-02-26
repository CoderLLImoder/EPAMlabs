using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4
{
    class Mystring
    {
        private char[] Chars;
        public Mystring()
        { }

        public Mystring(char[] Chars)
        {
            this.Chars = Chars;
        }

        public void set(string s)
        {
            Chars = s.ToCharArray();
        }
        public char[] get()
        {
            return (Chars);
        }

        public void show()
        {
            Console.WriteLine(Chars);
        }

        public static int Mylength( Mystring a)
        {
           
            return (a.Chars.Length);
        }

        public static Mystring operator + (Mystring a, Mystring b)
        {
            int x = Mylength(a); int y =Mylength(b);
            char[] sum=new char[x+y];
            for (int i=0; i< x; i++)
               {
                 sum[i] = a.Chars[i];
               }
            for (int i = 0; i < y; i++)
            {
                sum[x+i] = b.Chars[i];
            }
            
            return new Mystring(sum);
        }

    }
}
