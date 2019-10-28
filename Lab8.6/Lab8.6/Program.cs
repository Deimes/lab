using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab8._6
{
    class Program
    {
        static void Main(string[] args)
        {

            int a;

            Console.Write("Введите число: ");
            a = int.Parse(Console.ReadLine());

            if (a > 0 && a < 1000)
            {
                if (a > 9 && a < 100 && a % 2 == 0)
                {
                    Console.WriteLine("Двузначное четное число");
                }
                if (a > 9 && a < 100 && a % 2 == 1)
                {
                    Console.WriteLine("Двузначное нечетное число");
                }

                if (a > 99 && a % 2 == 0)
                {
                    Console.WriteLine("Трехзначное четное число");
                }

                if (a > 99 && a % 2 == 1)
                {
                    Console.WriteLine("Трехзначное нечетное число");
                }

                if (a < 10 && a % 2 == 1)
                {
                    Console.WriteLine("Одозначное нечетное число");
                }

                if (a < 10 && a % 2 == 0)
                {
                    Console.WriteLine("Однозначное четное число");
                }
            }
            else
            {
                Console.WriteLine("Число должно лежать в диопазоне от 1 до 999!!");
            }

            Console.ReadKey();
        }
    }
}
