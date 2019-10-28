using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab7._2
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b, c;
            bool d = true;

            Console.Write("Введите число А: ");
            a = int.Parse(Console.ReadLine());

            Console.Write("Введите число B: ");
            b = int.Parse(Console.ReadLine());

            Console.Write("Введите число C: ");
            c = int.Parse(Console.ReadLine());


            if (a < b && a < c && b < c)
            {
                Console.Write(d);
            }
            else
            {
                Console.Write(d = false);
            }
            Console.ReadKey();




        }
    }
}
