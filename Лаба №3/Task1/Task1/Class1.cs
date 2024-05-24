using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    public class Class1
    {
        public int Min(int a, int b)
        {
            if (a < b) { return a; }
            else
            {
                return b;
            }

            return a < b 
                ? a 
                : b;
        }
    }
}
