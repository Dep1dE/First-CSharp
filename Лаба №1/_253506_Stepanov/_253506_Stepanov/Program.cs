using System;

namespace Programm
{
    class Program
    {   
        static int input()
        {
            return Convert.ToInt32(Console.ReadLine());
        }
        static void Main(string[] args)
        {
            Console.WriteLine("a: ");
            int a, b, c;
            a=input();
            Console.WriteLine("b: ");
            b = input();
            c = a / b;
            Console.WriteLine("a/b = " + c);
        }
    }
}