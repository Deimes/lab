using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab7._3
{
    class Program
    {
        static void Main(string[] args)
        {
            int a;
            bool b = true;

            Console.Write("Введите число: ");
            a = int.Parse(Console.ReadLine());

            if (a % 2 == 0 && a <= 99 && a >= 10)
            {
                Console.WriteLine(b);
            }
            else
            {
                b = false;
                Console.WriteLine(b);
            }

            Console.ReadKey();


        }
    }
}
