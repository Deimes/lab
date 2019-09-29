using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4._6
{
    class Program
    {
        static void Main(string[] args)
        {
            double a1, b1, a2, b2, x, y, c1, c2;

            Console.WriteLine("Введите A1");
            a1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Введите B1");
            b1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Введите C1");
            c1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Введите A2");
            a2 = int.Parse(Console.ReadLine());

            Console.WriteLine("Введите B2");
            b2 = int.Parse(Console.ReadLine());

            Console.WriteLine("Введите C2");
            c2 = int.Parse(Console.ReadLine());

            x = (c1 * b2 + c2 * b1) / (a1 * b2 + a2 * b1);
            y = (c1 * a2 - c2 * a1) / (b1 * a2 + a1 * b2);

            Console.WriteLine(string.Format("x = {0:N2}, y = {1:N2}", x, y));
            Console.ReadKey();


        }
    }
}
