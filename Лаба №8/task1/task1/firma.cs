using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using task1;

namespace task2
{
    public class firma
    {
        tarif mytarif;
        IStrategy strategy;
        List<tarif> listOfTarifs = new List<tarif>();

        public void AddAbsDiscountTarif(string name, int cost, int discont) {
            strategy = new AddAbsDiscountTarif(discont);
            listOfTarifs.Add(new tarif(name, strategy.GetCost(cost)));
        }
        public void AddNoDiscountTarif(string name, int cost) {
            strategy = new AddNoDiscountTarif();
            listOfTarifs.Add(new tarif(name, strategy.GetCost(cost)));
        }

        public void FindSmallCost()
        {
            bool flag = false;
            tarif small = new tarif();
            double min = 1000000;
            for (int i = 0; i < listOfTarifs.Count(); ++i)
            {
                if (min >= listOfTarifs[i].getCost())
                {
                    flag = true;
                    small.SetName(listOfTarifs[i].getName());
                    small.SetCost(listOfTarifs[i].getCost());
                    min = listOfTarifs[i].getCost();

                }
            }
            if (flag)
            {
                Console.WriteLine("Тариф с минимальной ценой:");
                Console.WriteLine("Название: " + small.getName() + " Цена:" + small.getCost());
            }
            else
            {
                Console.WriteLine("Тариф не найден");
            }
        }
    }

    public interface IStrategy
    {
        double GetCost(int cost);
    }

    public class AddAbsDiscountTarif : IStrategy
    {
        private readonly int discount;

        public AddAbsDiscountTarif(int discount)
        {
            this.discount = discount;
        }
        public double GetCost(int cost)
        {
            return cost-((cost*discount)/100);
        }
    }

    public class AddNoDiscountTarif : IStrategy
    {
        public double GetCost(int cost)
        {
            return cost;
        }
    }
}
