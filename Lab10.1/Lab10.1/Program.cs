using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab10._1
{
    class Program
    {
        static void Main(string[] args)
        {
            double a;

            Console.Write("Введите цену за 1 кг конфет: ");
            a = int.Parse(Console.ReadLine());

            for (double i = 0.1; i < 1.0; i += 0.1)
                Console.WriteLine("Цена за {0} кг = {1}", i, a * i);
                Console.ReadKey();



        }
    }
}
