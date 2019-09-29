using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2._1
{
    class Program
    {
        static void Main(string[] args)
        {
            double s, x1, y1, x2, y2;
            Console.Write("Введите x1: ");
            x1 = int.Parse(Console.ReadLine());

            Console.Write("Введите y1: ");
            y1 = int.Parse(Console.ReadLine());

            Console.Write("Введите x2: ");
            x2 = int.Parse(Console.ReadLine());

            Console.Write("Введите y2: ");
            y2 = int.Parse(Console.ReadLine());

            s = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));
            Console.WriteLine(string.Format("Расстояние между двумя точками: {0:N2}", s));
            Console.ReadKey();

        }
    }
}
