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
                int z,k;
                double x, y, j;
                Console.WriteLine("Введите координату X: ");
                x = input();
                Console.WriteLine("Введите координату Y: ");
                y = input();
                if (y>0 || y<-100 || x>100 || x<-100) { z=1; }
                else if (y==-100&&(x>=100&&x<=100)) { z = 2; }
                else {
                    j = -Math.Abs(x);      
                    if(j==y) { z = 2; }
                    else if(y>j) { z = 1; }
                    else { z = 3; }
                }
                switch (z)
                {
                    case 1:
                        Console.WriteLine("Нет");
                        break;
                    case 2:
                        Console.WriteLine("На границе");
                        break;
                    case 3:
                        Console.WriteLine("Да");
                        break;
                    default:
                        Console.WriteLine("Ошибка");
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