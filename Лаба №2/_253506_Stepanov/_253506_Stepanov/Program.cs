using System;
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
            for (; ; )
            {
                Console.WriteLine("A: ");
                int a, b, sum, x,y;
                a = input();
                Console.WriteLine("Двузначное число: ");
                b = input();
                sum = b / 10 + b % 10;// b - ((b / 10) * 10) + (b / 10);
                if (a == 0) { x = 3; }
                else if (sum % a == 0) { x = 1; }
                else { x = 2; }
                switch (x)
                {
                    case 1:
                        Console.WriteLine("Кратно");
                        break;
                    case 2:
                        Console.WriteLine("НЕкратно");
                        break;
                    default:
                        Console.WriteLine("Ошибка ввода значений");
                        break;
                }                
                Console.WriteLine("Продолжить?");
                Console.WriteLine("1-Да");
                Console.WriteLine("2-Нет");
                y=input();
                switch (y)
                {
                    case 1:
                        Console.Clear();
                        break;
                    case 2:
                        return 0;
                    default:
                        Console.WriteLine("Ошибка ввода значений");
                        break;
                }
            }
        }
    }
}