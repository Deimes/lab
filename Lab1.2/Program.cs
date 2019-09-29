using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1._2
{
    class Program
    {
        static void Main(string[] args)
        {
            int d;
            double pi, l;
            pi = 3.14;
            Console.Write("Введите диаметр: ");
            d = int.Parse(Console.ReadLine());
            l = pi * d;
            Console.WriteLine(string.Format("Длина равна: {0}", l));
            Console.ReadKey();
        }
    }
}
