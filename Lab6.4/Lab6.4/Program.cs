using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab6._4
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b, c, n;

            Console.Write("Введите А: ");
            a = int.Parse(Console.ReadLine());


            Console.Write("Введите B: ");
            b = int.Parse(Console.ReadLine());


            Console.Write("Введите C: ");
            c = int.Parse(Console.ReadLine());

            n = (a / c) * (b / c);
            Console.WriteLine("Кол-во квадратов: {0} ", n);
            Console.WriteLine("Площадь незанятой части: {0}", a * b - n * c * c);
            Console.ReadKey();

        }
    }
}
