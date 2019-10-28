using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab10._4
{
    class Program
    {
        static void Main(string[] args)
        {
            double a, t = 0;
            int n;

            Console.Write("Введите число: ");
            a = int.Parse(Console.ReadLine());

            Console.Write("Введите степень этого числа: ");
            n = int.Parse(Console.ReadLine());

            for (int i = 0; i <= n; i += 1)
                Console.WriteLine(t += Math.Pow(a, i));
                Console.ReadKey();

        }
    }
}
