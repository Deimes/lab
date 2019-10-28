using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab13._1
{
    class Program
    {
        static void Main(string[] args)
        {
            int n;

            Console.Write("Введите число N: ");
            n = int.Parse(Console.ReadLine());

            int[] arr = new int[n];

            for (int i = 1; i < arr.Length; i += 1)
            {
                arr[i] = 2 * i - 1;
            }
            Console.Write("Массив arr: ");
            foreach (int x in arr)
            { Console.Write(x + " "); }
            Console.ReadKey();


        }


    }
}
