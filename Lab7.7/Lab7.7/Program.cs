using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab7._7
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b, c;
            bool d = true;

            Console.Write("Введите сторону треугольника А: ");
            a = int.Parse(Console.ReadLine());

            Console.Write("Введите сторону треугольника B: ");
            b = int.Parse(Console.ReadLine());

            Console.Write("Введите сторону треугольника C: ");
            c = int.Parse(Console.ReadLine());

            if ((a + b) > c && (a + c) > b && (b + c) > a)
            {
                Console.Write(d);

            }
            else
            {
                Console.Write(d = false);
            }
            Console.ReadKey();

        }
    }
}
