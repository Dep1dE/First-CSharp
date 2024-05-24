using System;
using System.Transactions;
using System.Reflection;
using Task3;
using Task5;
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
            tarifs tarif=new tarifs();
            register client= new register();
            for (; ; )
            {
                int k, z;
                Console.WriteLine("Введите 1, если хотите ввести тарифы");
                Console.WriteLine("Введите 2, если хотите зарегистрировать клиента и оформить заказ на перевозку груза");
                Console.WriteLine("Введите 3, вывод суммы заказа для определенного клиента");
                Console.WriteLine("Введите 4, подсчет суммарной стоимости всех заказов");
                z = input();
                switch (z)
                {
                    case 1:
                        Console.WriteLine("Введите стоимость легковесных грузов");
                        tarif.setLightweightTarif(input());
                        Console.WriteLine("Введите стоимость обычных грузов");
                        tarif.setOrdinaryTarif(input());
                        Console.WriteLine("Введите стоимость тяжеловесных грузов");
                        tarif.setHeavyweightOrdinary(input());
                        break;
                    case 2:
                        Console.WriteLine("Введите фио клиента");
                        string fio;
                        int weightOfGruz;
                        fio= Console.ReadLine();
                        Console.WriteLine("Введите вес груза клиента");
                        weightOfGruz=input();
                        client.MakeNewClient(fio, weightOfGruz, tarif);
                        break;
                    case 3:
                        Console.WriteLine("Введите фио клиента для поиска суммы заказа");
                        string f;
                        fio = Console.ReadLine();
                        int o = client.FindClient(fio);
                        if (o == -1)
                        {
                            Console.WriteLine("Клиент с такой фамилией не найден");
                        }
                        else
                        {
                            Console.WriteLine("Cуммы заказа этого клиента: "+o);
                        }
                        break;
                    case 4:
                        Console.WriteLine("Cуммарной стоимости всех заказов:" +client.sumManey());
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