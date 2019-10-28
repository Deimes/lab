using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab10._3
{
    class Program
    {
        static void Main(string[] args)
        {

           int a, t = 0;

            Console.Write("Введите число: ");
            a = int.Parse(Console.ReadLine());

            for (int i = 1; i <= a; i += 1)
                Console.WriteLine(t += 2 * i - 1);
                Console.ReadKey();

        }
    }
}
