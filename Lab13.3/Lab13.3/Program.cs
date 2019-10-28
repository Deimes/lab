using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab13._3
{
    class Program
    {
        static void Main(string[] args)
        {
            int n, a, b, s;

            Console.Write("Введите число N: ");
            n = int.Parse(Console.ReadLine());

            Console.Write("Введите первый член массива: ");
            a = int.Parse(Console.ReadLine());

            Console.Write("Введите второй член массива: ");
            b = int.Parse(Console.ReadLine());

            int[] arr = new int[n];
            arr[0] = a;
            arr[1] = b;
            s = a + b;

            for (int i = 2; i < arr.Length; i++)
            {
                arr[i] = s;
                s *= 2;

            }

            foreach (int x in arr)
            { Console.Write(x + " "); }
            Console.ReadKey();
        }
    }
}
