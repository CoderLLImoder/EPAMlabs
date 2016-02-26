using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    class code1
    {
          static void QSort(int L, int R, int[] arr)

            {
                int i = L;
                int j = R;
                int s;
                int x = arr[(L+R)/2];
                do
                {
                    while (arr[i] < x) i++;
                    while (arr[j] > x) j--;
                    if(i<= j)
                    {
                        s = arr[i];
                        arr[i] = arr[j];
                        arr[j] = s;
                        i++;
                        j--;
                    }

                } while (i <= j);
                if (L < j) QSort(L, j, arr);
                if (i < R) QSort(i, R, arr);
            }
        
        static void Main(string[] args)
        {
            const int n = 10;
            int[] Arr = new int[n];
            Random rnd = new Random();
            Console.Write("Исходный массив:");
            for (int i = 0; i < n; i++)
            {
                Arr[i] = rnd.Next(-100, 100);
                Console.Write(" " + Arr[i]);
            }
            Console.WriteLine();

            int max = Arr[0];
            int min = Arr[0];
            for (int i = 1; i < n; i++)
            {
                if(Arr[i]<min)
                {
                    min = Arr[i];
                }
                if (Arr[i] > max)
                {
                    max = Arr[i];
                }
            }
            Console.WriteLine("Максимальное значение max = " + max);
            Console.WriteLine("Минимальное значение min = " + min);
            QSort(0, n - 1, Arr);
            Console.Write("Отсортированный массив: ");
            foreach(int elem in Arr)
            {
                Console.Write(elem+" ");
            }
            Console.Read();

        }
    }
}
