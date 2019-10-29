using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab14._4
{
    class Program
    {
        static void Main(string[] args)
        {
            int N, max = -1, k = 0;

            Console.Write("Введите размер массива: ");
            N = int.Parse(Console.ReadLine());

            int[] arr = new int[N];
            
            for  (int i = 0; i < N; i++)
            {
                Console.Write("A[{0}] = ", i);
                arr[i] = int.Parse(Console.ReadLine());
            }

            for (int i = 1; i < N - 1; i++)
            {
                if (arr[i] > arr[i + 1] && arr[i] > arr[i - 1] )
                {
                    max = arr[i];
                    k = i;
                }
            }

            Console.WriteLine("Номер последнего локального максимума: {0} ", k);
            Console.ReadKey();


        }
    }
}
