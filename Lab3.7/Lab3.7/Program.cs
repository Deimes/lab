using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3._7
{
    class Program
    {
        static void Main(string[] args)
        {
            double a, t1, t2;
            Console.Write("Введите A: ");
            a = int.Parse(Console.ReadLine());

            t1 = a * a; // ^2
            t2 = a * t1; // ^3
            t1 = t2 * t1; // ^5
            t2 = t1 * t1; // ^10
            t1 = t2 * t1; // ^15

            Console.WriteLine(string.Format("{0} в 15 степени равно: {1}", a, t1));
            Console.ReadKey();


        }
    }
}
