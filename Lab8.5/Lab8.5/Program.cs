using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab8._5
{
    class Program
    {
        static void Main(string[] args)
        {
            int a;

            Console.WriteLine("Введите число: ");
            a = int.Parse(Console.ReadLine());

            if (a > 0 && a % 2 == 0)
            {
                Console.WriteLine("Положительное четное число");
            }

            if (a < 0 && a % 2 == 0)
            {
                Console.WriteLine("Отрицательное четное число");
            }

            if (a > 0 && a % 2 == 1)
            {
                Console.WriteLine("Положительное нечетное число");
            }

            if (a < 0 && a % 2 == -1)
            {
                Console.WriteLine("Отрицательное нечетное число");
            }

            if (a == 0)
            {
                Console.WriteLine("Нулевое число");
            }

            Console.ReadKey();

        }
    }
}
