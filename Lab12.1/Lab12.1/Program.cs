using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab12._1
{
    class Program
    {
        static void PowerA3(double a, out double b)
        {
            b = a * a * a;
        }

        static void Main(string[] args)
        {
            double a, b;

            Console.Write("Введите А: ");
            a = Convert.ToDouble(Console.ReadLine());


            PowerA3(a, out b);

            Console.WriteLine("{0} в 3 степени = {1}", a, b);
            Console.ReadKey();



        }
    }
}
