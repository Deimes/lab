using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab11._1
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b;

            Console.Write("Введите число А: ");
            a = int.Parse(Console.ReadLine());

            Console.Write("Введите число B: ");
            b = int.Parse(Console.ReadLine());

            if (a < b)
            {
                for (int i = 1; i <= a; i++)
                {
                    Console.WriteLine(a);
                }

                for (int i = 1; i <= b; i++)
                {
                    Console.WriteLine(b);
                }
            }

            else Console.WriteLine("B должно быть больше А !!!");

            Console.ReadKey();

        }
    }
}
