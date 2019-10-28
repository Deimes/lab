using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab11._2
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b;

            Console.Write("Введите длину отрезка А: ");
            a = int.Parse(Console.ReadLine());

            Console.Write("Введите длину отрезка B: ");
            b = int.Parse(Console.ReadLine());
            if (a > b)
            {
                while (a >= b)
                {
                    a = a - b;
                }
                Console.WriteLine("Длина не занятой части равна {0}", a);
            }
            else { Console.WriteLine("А должно быть больше B!"); }
            Console.ReadKey();

        }
    }
}
