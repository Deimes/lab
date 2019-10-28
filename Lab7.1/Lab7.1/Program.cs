using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab7._1
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b;
            bool c = true;

            Console.Write("Введите число А: ");
            a = int.Parse(Console.ReadLine());

            Console.Write("Введите число B: ");
            b = int.Parse(Console.ReadLine());

            if (a > 2 && b <= 3)
            {
                Console.Write(c);
                Console.ReadKey();
            }
            else
            {
                c = false;
                Console.Write(c);
                Console.ReadKey();
            }


        }
    }
}
