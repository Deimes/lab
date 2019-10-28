using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab8._4
{
    class Program
    {
        static void Main(string[] args)
        {
            int x, y;

            Console.Write("Введите значение точки по оси OX: ");
            x = int.Parse(Console.ReadLine());

            Console.Write("Введите значение точки по оси OY: ");
            y = int.Parse(Console.ReadLine());

            if ( x > 0 && y > 0 )
            {
                Console.WriteLine("Первая четверть");
            }

            if (x < 0 && y > 0)
            {
                Console.WriteLine("Вторая четверть");
            }

            if (x < 0 && y < 0)
            {
                Console.WriteLine("Третья четверть");
            }

            if (x > 0 && y < 0)
            {
                Console.WriteLine("Четвертая четверть");
            }

            Console.ReadKey();

        }
    }
}
