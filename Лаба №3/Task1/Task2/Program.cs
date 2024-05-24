using System;
using System.Transactions;
using Task2.Services;

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
            Class1 myclas = new Class1();
            for (; ; )
            {
                int k, z, x, y;
                Console.WriteLine("Введите Z:");
                z = input();
                myclas.F(z);
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