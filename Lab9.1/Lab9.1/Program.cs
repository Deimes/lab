using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab9._1
{
    class Program
    {
        static void Main(string[] args)
        {

            int a, b;

            Console.Write("Введите Номер дня: ");
            a = int.Parse(Console.ReadLine());

            Console.Write("Введите номер месяца: ");
            b = int.Parse(Console.ReadLine());

            switch(a)
            {
                case 1:
                    Console.Write("Первое");
                    break;

                case 2:
                    Console.Write("Второе");
                    break;

                case 3:
                    Console.Write("Третье");
                    break;

                case 4:
                    Console.Write("Четвертое");
                    break;

                case 5:
                    Console.Write("Пятое");
                    break;

                case 6:
                    Console.Write("Шестое");
                    break;

                case 7:
                    Console.Write("Седьмое");
                    break;

                case 8:
                    Console.Write("Восьмое");
                    break;

                case 9:
                    Console.Write("Девятое");
                    break;

                case 10:
                    Console.Write("Десятое");
                    break;

                case 11:
                    Console.Write("Одиннадцатое");
                    break;

                case 12:
                    Console.Write("Двенадцатое");
                    break;

                case 13:
                    Console.Write("Триндацатое");
                    break;

                case 14:
                    Console.Write("Четырнадцатое");
                    break;

                case 15:
                    Console.Write("Пятнадцатое");
                    break;

                case 16:
                    Console.Write("Шестнадцатое");
                    break;

                case 17:
                    Console.Write("Семнадцатое");
                    break;

                case 18:
                    Console.Write("Восемнадцатое");
                    break;

                case 19:
                    Console.Write("Девятнадцатое");
                    break;

                case 20:
                    Console.Write("Двадцатое");
                    break;

                case 21:
                    Console.Write("Двадцать первое");
                    break;

                case 22:
                    Console.Write("Двадцать второе");
                    break;

                case 23:
                    Console.Write("Двадцать третье");
                    break;

                case 24:
                    Console.Write("Двадцать четвертое");
                    break;

                case 25:
                    Console.Write("Двадцать пятое");
                    break;

                case 26:
                    Console.Write("Двадцать шестое");
                    break;

                case 27:
                    Console.Write("Двадцать седьмое");
                    break;

                case 28:
                    Console.Write("Двадцать восьмое");
                    break;

                case 29:
                    Console.Write("Двадцать девятое");
                    break;

                case 30:
                    Console.Write("Тридцатое");
                    break;

                case 31:
                    Console.Write("Тридцать первое");
                    break;

            }

            switch (b)
            {
                case 1:
                    Console.Write(" января");                 
                    break;

                case 2:
                    Console.Write(" февраля");                   
                    break;

                case 3:
                    Console.Write(" марта");                    
                    break;

                case 4:
                    Console.Write(" апреля");                   
                    break;

                case 5:
                    Console.Write(" мая");                    
                    break;

                case 6:
                    Console.Write(" июня");                    
                    break;

                case 7:
                    Console.Write(" июля");                    
                    break;

                case 8:
                    Console.Write(" августа");                
                    break;

                case 9:
                    Console.Write(" сентября");        
                    break;

                case 10:
                    Console.Write(" октября");
                    break;

                case 11:
                    Console.Write(" ноября");
                    
                    break;
                case 12:
                    Console.Write(" декабря");           
                    break;
            }
            Console.ReadKey();

        }
    }
}
