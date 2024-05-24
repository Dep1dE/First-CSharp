using task1;

class Program
{
    static void Main(string[] args)
    {
        matrix m1=new matrix(3,3,1,5);
        matrix m2 = new matrix(5, 6, 7, 8);
        Console.WriteLine(m1+m2);
        Console.WriteLine(m1-m2);
        Console.WriteLine(++m1);
        Console.WriteLine(--m1);
        Console.WriteLine(m1*2);
        Console.WriteLine(m1 / 1);
        Console.WriteLine((int)m1);
        Console.WriteLine((matrix)3);
        var a = (double)3;


    }
}