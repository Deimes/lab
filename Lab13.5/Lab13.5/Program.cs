using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab13._5
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

            for (int i = 1; i < n; i += 2)
            {
                Console.WriteLine(arr[i]);
            }

            for (int i = 0; i < n; i += 2)
            {
                Console.WriteLine(arr[i]);
            }
            Console.ReadKey();
            
        }
    }
}
