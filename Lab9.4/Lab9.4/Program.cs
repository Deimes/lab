using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab9._4
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, t, t1, t2, t3;

            Console.Write("Введите число в диапозоне 100-999: ");
            a = int.Parse(Console.ReadLine());

            if (a < 100 || a > 999)
            {
                Console.WriteLine("Число вне диапозона!");
                Console.ReadKey();
                return;
            }

            t = a / 100;

            switch (t)
            {
                case 1:
                    Console.Write("Сто ");
                    break;

                case 2:
                    Console.Write("Двести ");                   
                    break;

                case 3:
                    Console.Write("Триста ");
                    break;

                case 4:
                    Console.Write("Четыреста ");
                    break;

                case 5:
                    Console.Write("Пятьсот ");
                    break;

                case 6:
                    Console.Write("Шестьсот ");
                    break;

                case 7:
                    Console.Write("Семьсот ");
                    break;

                case 8:
                    Console.Write("Восемьсот ");
                    break;

                case 9:
                    Console.Write("Девятьсот ");
                    break;
            }

            if (a % 100 < 20 || a % 100 > 9)
            {
                t1 = a % 100;

                switch (t1)
                {
                    case 10:
                        Console.Write("десять ");
                        Console.ReadKey();
                        return;

                    case 11:
                        Console.Write("одиннадцать ");
                        Console.ReadKey();
                        return;

                    case 12:
                        Console.Write("двенадцать ");
                        Console.ReadKey();
                        return;

                    case 13:
                        Console.Write("тринадцать ");
                        Console.ReadKey();
                        return;

                    case 14:
                        Console.Write("четырнадцать ");
                        Console.ReadKey();
                        return;

                    case 15:
                        Console.Write("пятнадцать ");
                        Console.ReadKey();
                        return;

                    case 16:
                        Console.Write("шестнадцать ");
                        Console.ReadKey();
                        return;

                    case 17:
                        Console.Write("семнадцать ");
                        Console.ReadKey();
                        return;

                    case 18:
                        Console.Write("восемнадцать ");
                        Console.ReadKey();
                        return;

                    case 19:
                        Console.Write("девятнадцать ");
                        Console.ReadKey();
                        return;
                }
            }
           
                t2 = (a / 10) % 10;

                switch (t2)
                {
                    case 2:
                        Console.Write("двадцать ");
                        break;

                    case 3:
                        Console.Write("тридцать ");
                        break;

                    case 4:
                        Console.Write("сорок ");
                        break;

                    case 5:
                        Console.Write("пятьдесят ");
                        break;

                    case 6:
                        Console.Write("шестьдесят ");
                        break;

                    case 7:
                        Console.Write("семьдесят ");
                        break;

                    case 8:
                        Console.Write("восемьдесят ");
                        break;

                    case 9:
                        Console.Write("девяносто ");
                        break;

            }


            

            t3 = a % 10;

            switch(t3)
            {
                case 1:
                    Console.Write("один");
                    break;

                case 2:
                    Console.Write("два");
                    break;

                case 3:
                    Console.Write("три");
                    break;

                case 4:
                    Console.Write("четыре");
                    break;

                case 5:
                    Console.Write("пять");
                    break;

                case 6:
                    Console.Write("шесть");
                    break;

                case 7:
                    Console.Write("семь");
                    break;

                case 8:
                    Console.Write("восемь");
                    break;

                case 9:
                    Console.Write("девять");
                    break;


            }
            Console.ReadKey();
        }
    }
}
