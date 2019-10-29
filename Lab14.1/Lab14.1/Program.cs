using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab14._1
{
    class Program
    {
        static void Main(string[] args)
        {
            int n, k, l, sum = 0;

            Console.Write("Введите число N: ");
            n = int.Parse(Console.ReadLine());

            Console.Write("Введите число K: ");
            k = int.Parse(Console.ReadLine());

            Console.Write("Введите число L: ");
            l = int.Parse(Console.ReadLine());

            int[] arr = new int[n];
            if (l > k && l < n)
            {
                for (int i = 0; i < n; i++)
                {
                    Console.Write(string.Format("a[{0}] = ", i));
                    arr[i] = int.Parse(Console.ReadLine());
                }

                for (int i = k - 1; i <= l - 1; i++) sum += arr[i];

                Console.WriteLine("Среднее арифметическое равно: {0} ", (float)sum / (float)(l - k + 1));
            }
            else { Console.WriteLine("n > l > k !"); }
            Console.ReadKey();

        }
    }
}
