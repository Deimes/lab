using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab14._3
{
    class Program
    {
        static void Main(string[] args)
        {
            int min = 9999, n;
            Console.Write("Введите размер массива: ");
            n = int.Parse(Console.ReadLine());

            int [] arr = new int[n];

            for (int i = 0; i < n; i++)
            {
                Console.Write(string.Format("a[{0}] = ", i));
                arr[i] = int.Parse(Console.ReadLine());
            }

            for (int i = 0; i < n; i++)
            {
                if (i % 2 == 0)
                {
                    min = arr[i];
                }
            }
            Console.WriteLine("Минимальный элемент = {0} ", min);
            Console.ReadKey();
        }
    }
}
