using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab10._2
{
    class Program
    {
        static void Main(string[] args)
        {
            double a, n = 1;

            Console.Write("Введите кол-во сомножителей N: ");
            a = double.Parse(Console.ReadLine());

            for (double i = 0; i < a / 10; i += 0.1)
                n = n * (i + 1);

            Console.WriteLine("Ответ: {0}", n);
                Console.ReadKey();
        }
    }
}
