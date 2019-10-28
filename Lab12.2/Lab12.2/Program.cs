using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab12._2
{
    class Program
    {
        static int Sign(int a)
        {
            return a < 0 ? -1 : a == 0 ? 0 : 1;
        }

        static void Main(string[] args)
        {
            Console.Write("Введите A: ");
            int a = int.Parse(Console.ReadLine());
            Console.Write("Введите B: ");
            int b = int.Parse(Console.ReadLine());
            Console.WriteLine(Sign(a) + Sign(b));
            Console.ReadKey();
        }
    }
}
