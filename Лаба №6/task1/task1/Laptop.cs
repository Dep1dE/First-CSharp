using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using task1;

namespace task2
{
    class Laptop : computer
    {
        private int batteryCapacity;
        
        public Laptop(string brand, string model, int batteryCapacity) : base(brand, model)
        {
            this.batteryCapacity = batteryCapacity;
        }
        public override void TurnOn()
        {
            Console.WriteLine(brand+" "+model+" ноутбук включен");
        }

        public override void TurnOff()
        {
            Console.WriteLine(brand + " " + model + " ноутбук выключен");
        }

        public override void PrintInfo()
        {
            base.PrintInfo();
            Console.WriteLine("Объем батареи: "+ batteryCapacity+"mAh");
        }

    }
}