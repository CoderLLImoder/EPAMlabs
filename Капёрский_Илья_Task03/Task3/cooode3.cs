using System;
using System.Collections.Generic;
using System.Linq;
using System.Diagnostics;
using System.Threading;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    class cooode3
    {
        static void Main(string[] args)
        {
            string str = "";
            StringBuilder sb = new StringBuilder();
            int N = 100;
            Stopwatch stopWatch1 = new Stopwatch();
            stopWatch1.Start();
            for (int i = 0; i < N; i++)
            {
                str += "*";
            }
            stopWatch1.Stop();
            TimeSpan t1s = stopWatch1.Elapsed;
            Console.WriteLine("Время работы String: " + t1s);

            Stopwatch stopWatch2 = new Stopwatch();
            stopWatch2.Start();
            for (int i = 0; i < N; i++)
            {
                sb.Append("*");
            }
            stopWatch2.Stop();
            TimeSpan t2s = stopWatch2.Elapsed;
            Console.WriteLine("Время работы StringBuilder: " + t2s);
            Console.Read();
        }
    }
}
