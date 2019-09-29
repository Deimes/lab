using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3._5
{
    class Program
    {
        static void Main(string[] args)
        {
            double x, y;
            Console.WriteLine("Введите X");
            x = int.Parse(Console.ReadLine());

            y = 4 * Math.Pow((x - 3), 6) - 7 * Math.Pow((x - 3), 3) + 2;

            Console.WriteLine(string.Format("Значение равно: {0}", y));
            Console.ReadKey();
        }
    }
}
