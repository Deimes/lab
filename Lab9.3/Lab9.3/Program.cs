using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab9._3
{
    class Program
    {
        static void Main(string[] args)
        {
            int a;

            Console.WriteLine("Введите число в диапозоне 10-40");
            a = int.Parse(Console.ReadLine());

            if (a < 10 || a > 40)
            {
                Console.WriteLine("Вне диапазона!");
                Console.ReadKey();
            }

            switch (a)
            {
                case 10:
                    Console.WriteLine("Десять учебных заданий");
                    Console.ReadKey();
                    return;

                case 11:
                    Console.WriteLine("Одиннадцать учебных заданий");
                    Console.ReadKey();
                    return;

                case 12:
                    Console.WriteLine("Двенадцать учебных заданий");
                    Console.ReadKey();
                    return;

                case 13:
                    Console.WriteLine("Тринадацать учебных заданий");
                    Console.ReadKey();
                    return;

                case 14:
                    Console.WriteLine("Четырнадцать учебных заданий");
                    Console.ReadKey();
                    return;

                case 15:
                    Console.WriteLine("Пятнадцать учебных заданий");
                    Console.ReadKey();
                    return;

                case 16:
                    Console.WriteLine("Шестнадцать учебных заданий");
                    Console.ReadKey();
                    return;

                case 17:
                    Console.WriteLine("Семнадцать учебных заданий");
                    Console.ReadKey();
                    return;

                case 18:
                    Console.WriteLine("Восемнадцать учебных заданий");
                    Console.ReadKey();
                    return;

                case 19:
                    Console.WriteLine("Девятнадцать учебных заданий");
                    Console.ReadKey();
                    return;

                case 20:
                    Console.WriteLine("Двадцать учебных заданий");
                    Console.ReadKey();
                    return;

                case 21:
                    Console.WriteLine("Двадцать одно учебное задание");
                    Console.ReadKey();
                    return;

                case 22:
                    Console.WriteLine("Двадцать два учебных заданий");
                    Console.ReadKey();
                    return;

                case 23:
                    Console.WriteLine("Двадцать три учебных заданий");
                    Console.ReadKey();
                    return;

                case 24:
                    Console.WriteLine("Двадцать четыре учебных заданий");
                    Console.ReadKey();
                    return;

                case 25:
                    Console.WriteLine("Двадцать пять учебных заданий");
                    Console.ReadKey();
                    return;

                case 26:
                    Console.WriteLine("Двадцать шесть учебных заданий");
                    Console.ReadKey();
                    return;

                case 27:
                    Console.WriteLine("Двадцать семь учебных заданий");
                    Console.ReadKey();
                    return;

                case 28:
                    Console.WriteLine("Двадцать восемь учебных заданий");
                    Console.ReadKey();
                    return;

                case 29:
                    Console.WriteLine("Двадцать девять учебных заданий");
                    Console.ReadKey();
                    return;


                case 30:
                    Console.WriteLine("Тридцать учебных заданий");
                    Console.ReadKey();
                    return;

                case 31:
                    Console.WriteLine("Тридцать одно учебное задание");
                    Console.ReadKey();
                    return;

                case 32:
                    Console.WriteLine("Тридцать два учебных заданий");
                    Console.ReadKey();
                    return;

                case 33:
                    Console.WriteLine("Тридцать три учебных заданий");
                    Console.ReadKey();
                    return;

                case 34:
                    Console.WriteLine("Тридцать четыре учебных заданий");
                    Console.ReadKey();
                    return;


                case 35:
                    Console.WriteLine("Тридцать пять учебных заданий");
                    Console.ReadKey();
                    return;

                case 36:
                    Console.WriteLine("Тридцать шесть учебных заданий");
                    Console.ReadKey();
                    return;

                case 37:
                    Console.WriteLine("Тридцать семь учебных заданий");
                    Console.ReadKey();
                    return;

                case 38:
                    Console.WriteLine("Тридцать восемь учебных заданий");
                    Console.ReadKey();
                    return;

                case 39:
                    Console.WriteLine("Тридцать девять учебных заданий");
                    Console.ReadKey();
                    return;

                case 40:
                    Console.WriteLine("Сорок учебных заданий");
                    Console.ReadKey();
                    return;

            } 

        }
    }
}
