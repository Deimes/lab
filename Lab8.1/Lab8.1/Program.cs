using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab8._1
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b;

            Console.Write("Введите первое число: ");
            a = int.Parse(Console.ReadLine());

            Console.Write("Введите второе число: ");
            b = int.Parse(Console.ReadLine());

            if (a == b)
            {
                a = 0;
                b = 0;
                Console.Write("A = {0}, B = {1}", a, b);
                Console.ReadKey();
                return;

            }

            if (a > b)
            {
                b = a;
                Console.Write("A = {0}, B = {1}", a, b);            
            }
            
            else
            {
               a = b;
                Console.Write("A = {0}, B = {1}", a, b);
            }

            Console.ReadKey();


        }
    }
}
