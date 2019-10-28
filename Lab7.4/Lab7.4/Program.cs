using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab7._4
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b, c, f;
            bool d = true;

            Console.Write("Введите трехзначное число: ");
            a = int.Parse(Console.ReadLine());

            b = a / 100; // 1-я цифра
            f = (a / 10) % 10; // 2 цифра
            c = a % 10; // 3-я цифра

            if (a >= 100 && a <= 1000)
            {
                if (b < f && f < c || b > f && f > c)
                {
                    Console.WriteLine(d);
                }
                else { Console.WriteLine(d = false); }
            }

            Console.ReadKey();

        }
    }
}
