using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab5._4
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b, c;

            Console.WriteLine("Введите двузначное число");
            a = int.Parse(Console.ReadLine());

            b = a / 10;
            c = a % 10;

            Console.WriteLine(string.Format("При перестановке цифр данного числа ответ: {0}{1}", c, b));
            Console.ReadKey();

        }
    }
}
