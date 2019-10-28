using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab13._2
{
    class Program
    {
        static void Main(string[] args)
        {
            int n, a, d;           
            Console.Write("Введите N: ");
            n = int.Parse(Console.ReadLine());
            Console.Write("Введите первый член А: ");
            a = int.Parse(Console.ReadLine());
            Console.Write("Знаменатель D: ");
            d = int.Parse(Console.ReadLine());

            int[] arr = new int[n];
            arr[0] = a;

            for (int i = 1; i < arr.Length; i++)
            {
               arr[i] = arr[i - 1] * d;               
            }

            foreach (int x in arr)
            { Console.Write(x + " "); }
            Console.ReadKey();




        }
    }
}
