using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab6._2
{
    class Program
    {
        static void Main(string[] args)
        {
            double n;

            Console.Write("Введите номер дня: ");
            n = int.Parse(Console.ReadLine());

            if (n >= 1 && n <= 365)
            {
                while (n > 7)
                {
                    n = n - 7;
                }
                if (n == 0)
                {
                    Console.WriteLine("Воскресенье");
                }
                if (n == 1)
                {
                    Console.WriteLine("Понедельник");
                }
                if (n == 2)
                {
                    Console.WriteLine("Вторник");
                }
                if (n == 3)
                {
                    Console.WriteLine("Среда");
                }
                if (n == 4)
                {
                    Console.WriteLine("Четверг");
                }
                if (n == 5)
                {
                    Console.WriteLine("Пятница");
                }
                if (n == 6)
                {
                    Console.WriteLine("Суббота");
                }
            }
            else { Console.WriteLine("Число вне диапозона!"); }

            Console.ReadKey();




        }
    }
}
