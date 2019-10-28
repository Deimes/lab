using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab6._3
{
    class Program
    {
        static void Main(string[] args)
        {
            double n, k, a;

            Console.Write("Введите номер дня недели для 1-го января: ");
            n = int.Parse(Console.ReadLine());



            if (n < 8)
            {
                Console.Write("Введите номер дня: ");
                k = int.Parse(Console.ReadLine());

                a = ((n % 7) + (k - 1)) % 7;

                if (a == 1)
                {
                    Console.Write(string.Format("Понедельник"));
                }

                if (a == 2)
                {
                    Console.Write(string.Format("Вторник"));
                }

                if (a == 3)
                {
                    Console.Write(string.Format("Среда"));
                }

                if (a == 4)
                {
                    Console.Write(string.Format("Четверг"));
                     
                }

                if (a == 5)
                {
                    Console.Write(string.Format("Пятница"));
                     
                }

                if (a == 6)
                {
                    Console.Write(string.Format("Суббота"));
                     
                }

                if (a == 7)
                {
                    Console.Write(string.Format("Воскресенье"));
                     
                }

            }
            else
            {
                Console.Write("Вы ввели значение для 1-го дня января больше 7!");
                 
            }
            Console.ReadKey();


        }
    }
}
