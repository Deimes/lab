using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4._3
{
    class Program
    {
        static void Main(string[] args)
        {
            int x, y, a;

            Console.WriteLine("Введите кол-во кг конфет");
            x = int.Parse(Console.ReadLine());

            Console.WriteLine("Введите цену за это количество");
            a = int.Parse(Console.ReadLine());

            y = a / x;

            Console.WriteLine(string.Format("1 кг стоит {0} рублей", y));
            Console.ReadKey();


        }
    }
}
