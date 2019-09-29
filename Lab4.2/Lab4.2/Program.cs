using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4._2
{
    class Program
    {
        static void Main(string[] args)
        {
            double a, b, p;
            Console.WriteLine("Введите значение угла в радианах");
            a = Convert.ToDouble(Console.ReadLine());
            p = 180;
            b = a * p;

            Console.WriteLine(string.Format("Значение этого угла в градусах равна: {0}", b));
            Console.ReadKey();



        }
    }
}
