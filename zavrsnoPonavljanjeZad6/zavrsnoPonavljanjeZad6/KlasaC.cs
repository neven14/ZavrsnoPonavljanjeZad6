using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zavrsnoPonavljanjeZad6
{
    class KlasaC
    {
        public int Zbroj(int[] Broj)
        {
            int Zbroj = Broj.Sum();
            return Zbroj;
        }
        public double Prosjek(int[] Broj)
        {
            double Prosjek = Broj.Average();
            return Prosjek;
        }
    }
}
