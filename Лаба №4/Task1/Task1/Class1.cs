using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    public class TVshop
    {
        TV tv;
        public string name;
        private int count;
        private int maney;

        private static TVshop instance;
        public void setCount(int count)
        {
            this.count = count;
        }
        public void setManey(int maney)
        {
            this.maney = maney;
        }

        public static TVshop GetShop()
        {
            return instance ??= new TVshop();
        }





        public void setCost(int cost)
        {
            tv.cost = cost;
        }
        public int countOfManey()
        {
            return maney * count;
        }
            private TVshop()
        {
            name = "";
            count = 0;
            maney = 0;
        }

    }
    public class TV
    {
        public int cost;
    }
}

