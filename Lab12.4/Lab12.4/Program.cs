using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab12._4
{
    class Program
    {
        static int Quarter(int x, int y)
        {
            if (x > 0 && y > 0) return 1;
            if (x < 0 && y > 0) return 2;
            if (x < 0 && y < 0) return 3;
            if (x > 0 && y < 0) return 4;
            return x;
        }

        static void Main(string[] args)
        {
            int x, y, t;

            Console.Write("Введите x: ");
            x = int.Parse(Console.ReadLine());

            Console.Write("Введите y: ");
            y = int.Parse(Console.ReadLine());

            t = Quarter(x, y);

            if (t == 1) Console.WriteLine("Первая четверть");
            if (t == 2) Console.WriteLine("Вторая четверть");
            if (t == 3) Console.WriteLine("Третья четверть");
            if (t == 4) Console.WriteLine("Четвертая четверть");

            Console.ReadKey();



        }
    }
}
