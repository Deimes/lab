using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab5._1
{
    class Program
    {
        static void Main(string[] args)
        {
            double a, b;

            Console.WriteLine("Введите количество байтов: ");
            a = int.Parse(Console.ReadLine());

            b = a / 1024;

            Console.WriteLine(string.Format("{0:N2} килобайт", b));
            Console.ReadKey();

        }
    }
}
