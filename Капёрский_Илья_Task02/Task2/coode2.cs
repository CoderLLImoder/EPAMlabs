using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    class coode2
    {
        static void Main(string[] args)
        {
            const int n = 3;
            int[,,] Arr3D = new int[n, n, n];
            Random rnd = new Random();
            Console.WriteLine("Исходный массив:");
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("i=" + i + ":");
                for (int j = 0; j < n; j++)
                {
                    for (int k = 0; k < n; k++)
                    {
                        Arr3D[i,j,k] = rnd.Next(-9, 9);
                        if(Arr3D[i,j,k]<0)
                        Console.Write(" " + Arr3D[i, j, k]);
                        else
                        Console.Write("  " + Arr3D[i, j, k]);
                    }
                    Console.WriteLine();
                }
                Console.WriteLine();
            }

            Console.WriteLine("Полуенный массив:");
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("i=" + i + ":");
                for (int j = 0; j < n; j++)
                {
                    for (int k = 0; k < n; k++)
                    {
                        if (Arr3D[i, j, k] < 0)
                        Console.Write(" " + Arr3D[i, j, k]);
                        else
                        {
                            Arr3D[i, j, k] = 0;
                            Console.Write("  " + Arr3D[i, j, k]);
                        }
                    }
                    Console.WriteLine();
                }
                Console.WriteLine();
            }
            Console.Read();
        }
    }
}
