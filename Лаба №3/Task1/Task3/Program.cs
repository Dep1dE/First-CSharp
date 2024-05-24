using System;
using System.Transactions;
using Task3;

namespace Programm
{
    class Program
    {
        static int input()
        {
            return Convert.ToInt32(Console.ReadLine());
        }
        static int Main(string[] args)
        {
            DateService myclas = new DateService();
            for (; ; )
            {
                int k, z;
                Console.WriteLine("Введите 1, если хотите определить день недели произвольной даты");
                Console.WriteLine("Введите 2, если хотите определить, сколько дней пройдет между датами");
                z = input();
                switch (z)
                {
                    case 1:
                        string date;
                        Console.WriteLine("Введите дату");
                        date =Console.ReadLine();
                        myclas.GetDay(date);
                        break;
                    case 2:
                        int day, month, year;
                         Console.WriteLine("Введите номер дня");
                        day = input();
                        Console.WriteLine("Введите номер месяца");
                        month = input();
                        Console.WriteLine("Введите номер года");
                        year = input();
                        myclas.GetDaysSpan(day,month,year);
                        break;
                    default:
                        Console.WriteLine("Ошибка ввода");
                        break;
                }
                Console.WriteLine("Продолжить?");
                Console.WriteLine("1-Да");
                Console.WriteLine("2-Нет");
                k = input();
                switch (k)
                {
                    case 1:
                        Console.Clear();
                        break;
                    case 2:
                        return 0;
                    default:
                        Console.WriteLine("Ошибка ввода");
                        break;
                }
            }
        }
    }
}