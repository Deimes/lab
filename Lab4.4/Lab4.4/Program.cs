using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4._4
{
    class Program
    {
        static void Main(string[] args)
        {
            int v1, v2, s1, s2, t, s;

            Console.WriteLine("Введите скорость первого автомобиля в км/ч ");
            v1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Введите скорость второго автомобиля в км/ч ");
            v2 = int.Parse(Console.ReadLine());

            Console.WriteLine("Введите прошедшее с момента старта время: ");
            t = int.Parse(Console.ReadLine());

            s1 = v1 * t;
            s2 = v2 * t;

            s = s2 + s1;

            Console.WriteLine(string.Format("Через {0} часа(ов) расстояние между ними будет равно: {1} км", t, s));
            Console.ReadKey();

        }
    }
}
