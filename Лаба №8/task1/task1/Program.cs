using System.Transactions;
using task1;
using task2;
using static System.Formats.Asn1.AsnWriter;

class Program
{
    static void Main(string[] args)
    {
        firma f=new firma();
        f.AddAbsDiscountTarif("dvd", 123, 20);
        f.AddNoDiscountTarif("vd", 100);
        f.FindSmallCost();
    }
}