using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task2;
using Task4;

namespace Task3
{
    internal class gruz
    {
        private TypeOfGruz Weight;
        public TypeOfGruz setWeight(int weight)
        {
            if (weight == 0) { Weight  = TypeOfGruz.None; }
            else if(weight <=80) { Weight = TypeOfGruz.Lightweight; }
            else if (weight <= 500) { Weight = TypeOfGruz.Ordinary; }
            else { Weight = TypeOfGruz.Heavyweight; }
            return Weight;
        }
    }
}
