using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4._5
{
    class Program
    {
        static void Main(string[] args)
        {
 
            double x, a, b;

            Console.WriteLine("Введите коэффициент А");
            a = int.Parse(Console.ReadLine());

            Console.WriteLine("Введите коэффициент B");
            b = int.Parse(Console.ReadLine());

            x = -b / a;

            Console.WriteLine(string.Format("{0}X + {1} = 0, X = {2:N2}",a, b, x));
            Console.ReadKey();

        }
    }
}
