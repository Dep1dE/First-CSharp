using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task1
{
    abstract class computer
    {
        protected string brand;
        protected string model;

        public computer(string brand, string model)
        {
            this.brand = brand;
            this.model = model;
        }

        public abstract void TurnOn();      
        public abstract void TurnOff();

        public virtual void PrintInfo()
        {
            Console.WriteLine("Марка компьютера: "+brand);
            Console.WriteLine("Модель компьютера: "+model);
        }
    }

}
