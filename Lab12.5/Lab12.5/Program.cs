using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab12._5
{
    class Program
    {
        static double Fact2(double n)
        {
            double rez = 1;

            for (int i = n % 2 == 0 ? 2 : 1; i <= n; i += 2)
            {
                rez *= i;
            }
            return rez;
        }

        static void Main(string[] args)
        {
            double n;

         

            for (int i = 1; i < 6; i++)
            {
                Console.Write("Введите {0} число: ", i);
                n = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine(Fact2(n));
            }
            Console.ReadKey();


        }
    }
}
