using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1._1
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b, s, p;
            Console.Write("Введите а: ");
            a = int.Parse(Console.ReadLine());
            Console.Write("Введите b: ");
            b = int.Parse(Console.ReadLine());
            s = a * b;
            p = 2 * (a + b);
            Console.WriteLine(string.Format("Периметр равен: {0} ", p));
            Console.WriteLine(string.Format("Площадь равна: {0}", s));
            Console.ReadKey();
        }
    }
}
