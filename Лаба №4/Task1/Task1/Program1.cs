using System;
using System.Transactions;
using System.Reflection;
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
            Type type= typeof(TVshop);
            ConstructorInfo constructor = 
                type.GetConstructor(BindingFlags.Instance | BindingFlags.NonPublic, null, new Type[0], null);
            TVshop obj=(TVshop)constructor.Invoke(null);

           

            for (; ; )
            {
                int k, z;
                Console.WriteLine("Введите 1, если хотите заполнить информацию о телевизорах");
                Console.WriteLine("Введите 2, если хотите подсчитать общую выручку магазина");
                Console.WriteLine("Введите 3, если хотите изменить стоимость телевизора");
                z = input();
                switch (z)
                {
                    case 1:
                        Console.WriteLine("Введите стоимость телевизора");
                        obj.setManey(input());
                        Console.WriteLine("Введите наименование телевизора");
                        obj.name= Console.ReadLine();
                        Console.WriteLine("Введите число покупок");
                        obj.setCount(input());
                        break;
                    case 2:
                        Console.WriteLine("Общая выручка: "+obj.countOfManey());
                        break;
                    case 3:
                        Console.WriteLine("Введите новую стоимость телевизора");
                        obj.setManey(input());
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