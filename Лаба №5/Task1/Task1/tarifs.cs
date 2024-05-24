using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task5
{
    internal class tarifs
    {
        private int LightweightTarif;
        private int OrdinaryTarif;
        private int HeavyweighTarif;
        public tarifs(){
            this.LightweightTarif = 0; this.OrdinaryTarif = 0; this.HeavyweighTarif = 0; }
        public void setLightweightTarif(int LightweightTarif)
        {
            this.LightweightTarif = LightweightTarif;
        }
        public void setOrdinaryTarif(int OrdinaryTarif)
        {
            this.OrdinaryTarif = OrdinaryTarif;
        }
        public void setHeavyweightOrdinary(int HeavyweighTarif)
        {
            this.HeavyweighTarif = HeavyweighTarif;
        }

        public int getLightweightTarif()
        {
            return this.LightweightTarif;
        }

        public int getOrdinaryTarif()
        {
            return this.OrdinaryTarif;
        }

        public int getHeavyweighTarif()
        {
            return this.HeavyweighTarif;
        }
    }
}
