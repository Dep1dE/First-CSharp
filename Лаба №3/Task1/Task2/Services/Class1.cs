using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2.Services
{
    internal class Class1
    {
        public void F(int z)
        {
            double x, y;
            if (z > 0)
            {
                Console.WriteLine("Идем по первой ветке");
                x=1.0/(z*z+2*z);
                y = f1(x);
                Console.WriteLine("Ответ: y= " + y);
            }
            else if (z<=0) {
                Console.WriteLine("Идем по второй ветке");
                x = 1 - (z * z * z);
                y = f1(x);
                Console.WriteLine("Ответ: y= " + y);
            }
        }
        public double f1(double x)
        {
            double y;
            y = (2*Math.Exp((-3)*x)-4*x*x) / (Math.Log(Math.Abs(x))+x);
            return y;
        }
    }
}
