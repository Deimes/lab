using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab7._6
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b, c;
            bool d = true;

            Console.Write("Введите сторону треугольника А: ");
            a = int.Parse(Console.ReadLine());

            Console.Write("Введите сторону треугольника B: ");
            b = int.Parse(Console.ReadLine());

            Console.Write("Введите сторону треугольника C: ");
            c = int.Parse(Console.ReadLine());

            if (Math.Pow(a, 2) + Math.Pow(b, 2) == Math.Pow(c, 2)) {

                Console.Write(d);
            }
            else {
                
                Console.Write(d = false);
            }

            Console.ReadKey();


        }
    }
}
