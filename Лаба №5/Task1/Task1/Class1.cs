using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task2;
using Task3;
using Task5;

namespace Task1
{
    internal class register
    {
        client Client;
    List<client> listOfClients= new List<client>();
        public int sumManey()
        {
            int sum=0;
            for (int i = 0; i < listOfClients.Count(); i++)
            {
                sum += listOfClients[i].getCostOfGruz();
            }
            return sum;
        }
        public int FindClient(string fio)
        {
            bool flag=false;
            int o=0;
            for (int i = 0; i < listOfClients.Count(); i++)
            {
                if (listOfClients[i].getFio()==fio)
                {
                    flag= true;
                    o= listOfClients[i].getCostOfGruz();
                    break;
                }
            }
            if (!flag)
            {
                return -1;
            }
            else
            {
                return o;
            }
        }
        public void MakeNewClient(string fio,int waight, tarifs tarif)
        {
            Client=new client();
            Client.setFio(fio);
            Client.setcost(waight, tarif);
            listOfClients.Add(Client);
        }
    }
    
}
