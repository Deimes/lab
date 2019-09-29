using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab5._2
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b, c;

            Console.WriteLine("Введите A");
            a = int.Parse(Console.ReadLine());

            Console.WriteLine("Введите B");
            b = int.Parse(Console.ReadLine());

            if (a > b)
            {
                c = a / b;
                Console.WriteLine(string.Format("На отрезке А размещено {0} отрезков B", c));
                Console.ReadKey();

            } else
            {
                Console.WriteLine("А должно быть больше В!");
                Console.ReadKey();
            }
          
        }
    }
}
