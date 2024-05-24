using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task3;
using Task4;
using Task5;

namespace Task2
{
    internal class client
    {
        gruz gruz=new gruz();
        private string fio="";
        private int costOfGruz;
        public void setFio(string fio) { this.fio = fio; }
        public void setcost(int waight, tarifs tarif) { this.costOfGruz = SetCostOfGruz(waight, tarif); }

        public string getFio() { return fio; }
        public int getCostOfGruz() { return costOfGruz; }

        public int SetCostOfGruz(int w, tarifs tarif)
        {

            switch (gruz.setWeight(w))
            {
                case TypeOfGruz.None:
                    return  0;
                case TypeOfGruz.Lightweight:
                    return tarif.getLightweightTarif();
                case TypeOfGruz.Ordinary:
                    return  tarif.getOrdinaryTarif();
                case TypeOfGruz.Heavyweight:
                    return  tarif.getHeavyweighTarif();
                default:
                    return 0;
            }
        }
    }
}
