using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2._3
{
    class Program
    {
        static void Main(string[] args)
        {
            double a, b, c, ac, bc, proiz;
            Console.Write("Введите точку A: ");
            a = int.Parse(Console.ReadLine());

            Console.Write("Введите точку B: ");
            b = int.Parse(Console.ReadLine());

            Console.Write("Введите точку C: ");
            c = int.Parse(Console.ReadLine());

            if (c > a && c < b || c < a && c > b)
            {
                ac = Math.Abs(c - a);
                bc = Math.Abs(c - b);
                proiz = ac * bc;
                Console.WriteLine(string.Format("AC = {0}, BC = {1}, Произведение длин отрезков = {2}", ac, bc, proiz));
            }
            else {
                Console.WriteLine("C не находится между точками А и B");

            }

            Console.ReadKey();

        }
    }
}
