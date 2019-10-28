using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab8._2
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = new int[3];
        
            Console.Write("Введите первое число: ");
            arr[0] = int.Parse(Console.ReadLine());

            Console.Write("Введите второе число: ");
            arr[1] = int.Parse(Console.ReadLine());

            Console.Write("Введите третье число: ");
            arr[2] = int.Parse(Console.ReadLine());

            Array.Sort(arr);
            Console.WriteLine("Сумма равна: {0}", arr[1] + arr[2]);
            Console.ReadKey();


        }
    }
}
