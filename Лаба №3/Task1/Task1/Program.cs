using System;
using Task1;

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
            Class1 myclas= new Class1();
            for (; ; )
            {   
                int k,z,x,y;
                Console.WriteLine("Введите X:");
                x=input();
                Console.WriteLine("Введите Y:");
                y = input();
                z=myclas.Min(x,2*y+x)-myclas.Min(7*x+2*y,y);
                Console.WriteLine("Ответ: z= "+z);
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