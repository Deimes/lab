using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab13._4
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
                Console.Write(string.Format("a[{0}] : ", i));
                arr[i] = int.Parse(Console.ReadLine());
            }

            for (int i = 0; i < n / 2; ++i)
            {
                Console.WriteLine(arr[i]);
                Console.WriteLine(arr[n - i - 1]);
            }

            if (n % 2 != 0) Console.WriteLine(arr[n / 2]);
            Console.ReadKey();
        }
    }
}
