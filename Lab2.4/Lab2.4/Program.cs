using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2._4
{
    class Program
    {
        static void Main(string[] args)
        {
            double h, shir, x1, y1, x2, y2, p, s;
            Console.Write("Введите координату x1: ");
            x1 = int.Parse(Console.ReadLine());

            Console.Write("Введите координату y1: ");
            y1 = int.Parse(Console.ReadLine());

            Console.Write("Введите координату x2: ");
            x2 = int.Parse(Console.ReadLine());

            Console.Write("Введите координату y2: ");
            y2 = int.Parse(Console.ReadLine());

            h = Math.Abs(y2 - y1);
            shir = Math.Abs(x2 - x1);

            p = 2 * (h + shir);
            s = h * shir;

            Console.WriteLine(string.Format("Периметр данного прямоугольника равен: {0}, Площадь равна: {1}", p, s));
            Console.ReadKey();



        }
    }
}
