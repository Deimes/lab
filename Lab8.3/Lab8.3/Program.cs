using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab8._3
{
    class Program
    {
        static void Main(string[] args)
        {
            double a, b, c, s;

            Console.Write("Введите значение точки А: ");
            a = int.Parse(Console.ReadLine());

            Console.Write("Введите значение точки B: ");
            b = int.Parse(Console.ReadLine());

            Console.Write("Введите значение точки C: ");
            c = int.Parse(Console.ReadLine());

            if (b == c)
            {
                s = Math.Abs(a - b);
                Console.WriteLine(string.Format("Так как значения точек равны, ближайшее расстояние равно: {0} ", s));
                Console.ReadKey();
                return;
            }

            if (b > c)
            {
                s = Math.Abs(a - b);
                Console.WriteLine(string.Format("Ближайшей точкой является точка B, ближайшее расстояние равно: {0} ", s));

            }
            else
            {
                s = Math.Abs(a - c);
                Console.WriteLine(string.Format("Ближайшей точкой является точка C, ближайшее расстояние равно: {0} ", s));
            }
            Console.ReadKey();


        }
    }
}
