using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task1
{
    public class tarif
    {
        private string name;
        private double cost;

        public tarif()
        {
            this.name = "";
            this.cost = 0;
        }
        public tarif(string name, double cost) { this.name = name;
            this.cost = cost;
        }
        public void SetName(string name)
        {
            this.name = name;
        }
        public void SetCost(double cost)
        {
            this.cost = cost;
        }
        public string getName() { return this.name; }
        public double getCost() { return this.cost;}
    }
}
