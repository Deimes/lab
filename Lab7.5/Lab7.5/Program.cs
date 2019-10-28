using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab7._5
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b, c, f, g;
            bool d = true;

            Console.Write("Введите четырехзначное число: ");
            a = int.Parse(Console.ReadLine());

            if (a >= 1000 && a <= 10000)
            {
                b = a / 1000; // 1
                c = a / 100 % 10; // 2
                f = a % 100 / 10; // 3
                g = a % 1000 % 10; // 4

                if (b == g && c == f)
                {
                    Console.WriteLine(d);
                }

                else
                {
                    Console.WriteLine(d = false);
                }
            }

            Console.ReadKey();


        }
    }
}
