using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using task1;
using task2;

namespace task1
{
    class Desktop : computer
    {
        private bool hasMonitor;

        public Desktop(string brand, string model, bool hasMonitor) : base(brand, model)
        {
            this.hasMonitor = hasMonitor;
        }

        public override void TurnOn()
        {
            Console.WriteLine(brand + " " + model + " рабочий стол включен");
        }

        public override void TurnOff()
        {
            Console.WriteLine(brand + " " + model + " рабочий стол выключен");
        }

        public override void PrintInfo()
        {
            base.PrintInfo();
            Console.WriteLine("Наличие монитора: "+ (hasMonitor ? "Есть" : "Нету"));
        }
    }
}
