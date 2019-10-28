using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab11._5
{
    class Program
    {
        static void Main(string[] args)
        {
            double a, b, t;

            Console.Write("Введите А: ");
            a = int.Parse(Console.ReadLine());

            Console.Write("Введите B: ");
            b = int.Parse(Console.ReadLine());

            while (b != 0 && a != 0)
            {
                if (a >= b)
                {
                    a = a % b;
                }
                else
                {
                    b = b % a;
                }
            }

            t = a + b;
            Console.WriteLine("Нод = {0}", t);
            Console.ReadKey();
        }
    }
}
