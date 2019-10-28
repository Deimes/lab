using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab9._5
{
    class Program
    {
        static void Main(string[] args)
        {
            int a;

            Console.Write("Введите год: ");

            a = int.Parse(Console.ReadLine());

        switch(((a - 1984) % 60) / 12)
            {
                case 0:
                    Console.Write("Год зел. ");
                    break;
                case 1:
                    Console.Write("Год красн. ");
                    break;

                case 2:
                    Console.Write("Год желт. ");
                    break;

                case 3:
                    Console.Write("Год бел. ");
                    break;

                case 4:
                    Console.Write("Год черн. ");
                    break;
            }

            switch (((a - 1984) % 60) % 12)
            {
                case 0:
                    Console.Write("крысы");
                    Console.ReadKey();
                    break;

                case 1:
                    Console.Write("коровы");
                    Console.ReadKey();
                    break;

                case 2:
                    Console.Write("тигра");
                    Console.ReadKey();
                    break;

                case 3:
                    Console.Write("зайца");
                    Console.ReadKey();
                    break;

                case 4:
                    Console.Write("дракона");
                    Console.ReadKey();
                    break;

                case 5:
                    Console.Write("змеи");
                    Console.ReadKey();
                    break;

                case 6:
                    Console.Write("лошади");
                    Console.ReadKey();
                    break;

                case 7:
                    Console.Write("овцы");
                    Console.ReadKey();
                    break;

                case 8:
                    Console.Write("обезьяны");
                    Console.ReadKey();
                    break;

                case 9:
                    Console.Write("курицы");
                    Console.ReadKey();
                    break;

                case 10:
                    Console.Write("собаки");
                    Console.ReadKey();
                    break;

                case 11:
                    Console.Write("свиньи");
                    Console.ReadKey();
                    break;

            }



        }
    }
}
