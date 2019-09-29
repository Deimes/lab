using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab5._5
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b, c, d;

            Console.WriteLine("Введите трехзначное число!");
            a = int.Parse(Console.ReadLine());

            b = a / 100;
            c = a % 100;

            Console.WriteLine(string.Format("Ответ: {0}{1}", c, b));
            Console.ReadKey();


        }
    }
}
