using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3._3
{
    class Program
    {
        static void Swap(ref int a, ref int b)
        {
            int c;
            c = a;
            a = b;
            b = c;
        }

        static void Main(string[] args)
        {
            int a, b, c;
            Console.Write("Введите а: ");
            a = int.Parse(Console.ReadLine());
            Console.Write("Введите b: ");
            b = int.Parse(Console.ReadLine());
            Console.Write("Введите c: ");
            c = int.Parse(Console.ReadLine());

            Swap(ref a, ref c);
            Swap(ref a, ref b);

            Console.WriteLine(string.Format("а равно: {0}, b равно: {1}, с равно: {2}", a, b, c));
            Console.ReadKey();
        }
    }
}
