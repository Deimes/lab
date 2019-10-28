using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab10._5
{
    class Program
    {
        static void Main(string[] args)
        {
            double a, n, t = 1, s = 1;

            Console.Write("Введите число: ");
            a = Convert.ToDouble(Console.ReadLine());

            Console.Write("Введите степень этого числа: ");
            n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                t = -t * a;
                s = s + t;
            }

            Console.WriteLine(s);
            Console.ReadKey();


        }
    }
}
