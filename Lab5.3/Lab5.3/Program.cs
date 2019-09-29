using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab5._3
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b, c, d;

            Console.WriteLine("Введите A");
            a = int.Parse(Console.ReadLine());

            Console.WriteLine("Введите B");
            b = int.Parse(Console.ReadLine());

            if (a > b)
            {
                c = a / b;
                d = a - (c * b);
                
                Console.WriteLine(string.Format("Длина, которая не занята на отрезке А равна: {0}  ", d));
                Console.ReadKey();

            }
            else
            {
                Console.WriteLine("А должно быть больше В!");
                Console.ReadKey();
            }

        }
    }
}
