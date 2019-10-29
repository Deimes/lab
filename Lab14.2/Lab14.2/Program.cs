using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab14._2
{
    class Program
    {
        static void Main(string[] args)
        {
            int n;
            Console.Write("Введите число N: ");
            n = int.Parse(Console.ReadLine());

            int[] arr = new int[n];

            for (int i = 0; i < n; i++)
            {
                Console.Write("a[{0}] = ", i);
                arr[i] = int.Parse(Console.ReadLine());
            }

            int k = arr[1] - arr[0];

            for (int i = 1; i < n && k != 0; i++)
            {
                if (k != arr[i] - arr[i - 1])
                {
                    k = 0;
                }
            }

            Console.WriteLine(k);
            Console.ReadKey();
        }
    }
}
