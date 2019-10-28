using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab9._2
{
    class Program
    {
        static void Main(string[] args)
        {
            int a;
            char s;

            Console.Write("Введите направление: ");
            s = Convert.ToChar(Console.ReadLine());

            Console.Write("Введите номер команды: ");
            a = int.Parse(Console.ReadLine());

            switch(a)
            {
                case 1: switch (s)
                    {
                        case 'Ю':
                            Console.WriteLine("Восток");
                            Console.ReadKey();
                            return;

                        case 'С':
                            Console.WriteLine("Запад");
                            Console.ReadKey();
                            return;

                        case 'З':
                            Console.WriteLine("Юг");
                            Console.ReadKey();
                            return;

                        case 'В':
                            Console.WriteLine("Север");
                            Console.ReadKey();
                            return;
                    } break;
            }

            switch (a)
            {
                case -1:
                    switch (s)
                    {
                        case 'Ю':
                            Console.WriteLine("Запад");
                            Console.ReadKey();
                            return;

                        case 'С':
                            Console.WriteLine("Восток");
                            Console.ReadKey();
                            return;

                        case 'З':
                            Console.WriteLine("Север");
                            Console.ReadKey();
                            return;

                        case 'В':
                            Console.WriteLine("Юг");
                            Console.ReadKey();
                            return;
                    }
                    break;
            }

            switch (a)
            {
                case 0:
                    switch (s)
                    {
                        case 'Ю':
                            Console.WriteLine("Юг");
                            Console.ReadKey();
                            return;

                        case 'С':
                            Console.WriteLine("Север");
                            Console.ReadKey();
                            return;

                        case 'З':
                            Console.WriteLine("Запад");
                            Console.ReadKey();
                            return;

                        case 'В':
                            Console.WriteLine("Восток");
                            Console.ReadKey();
                            return;
                    }
                    break;
            }






        }
    }
}
