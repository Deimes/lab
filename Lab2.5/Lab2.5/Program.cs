using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2._5
{
    class Program
    {
        static void Main(string[] args)
        {
            double x1, y1, x2, y2, x3, y3, p, s, a1, a2, a3;

            Console.Write("Введите координату x1: ");
            x1 = int.Parse(Console.ReadLine());

            Console.Write("Введите координату y1: ");
            y1 = int.Parse(Console.ReadLine());

            Console.Write("Введите координату x2: ");
            x2 = int.Parse(Console.ReadLine());

            Console.Write("Введите координату y2: ");
            y2 = int.Parse(Console.ReadLine());

            Console.Write("Введите координату x3: ");
            x3 = int.Parse(Console.ReadLine());

            Console.Write("Введите координату y3: ");
            y3 = int.Parse(Console.ReadLine());

            a1 = Math.Abs(Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2)));
            a2 = Math.Abs(Math.Sqrt(Math.Pow(x3 - x2, 2) + Math.Pow(y3 - y2, 2)));
            a3 = Math.Abs(Math.Sqrt(Math.Pow(x1 - x3, 2) + Math.Pow(y1 - y3, 2)));

            p = (a1 + a2 + a3);
            s = Math.Sqrt(p * (p - a1) * (p - a2) * (p - a3)) / 2;

            Console.WriteLine(string.Format("Периметр равен: {0:N2}, Площадь равна: {1:N2}", p, s));
            Console.ReadKey();


        }
    }
}
