using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zavrsnoPonavljanjeZad6
{
    class Program
    {
        static void Main(string[] args)
        {
            int zbroj;
            double prosjek;
            int[] Brojevi = new int[5];
            for (int i = 0; i < 5; i++)
            {
                Console.Write("Upisite broj " + (i + 1) + " : ");
                Brojevi[i] = Convert.ToInt32(Console.ReadLine());
            }
            KlasaC Objekt = new KlasaC();
            zbroj = Objekt.Zbroj(Brojevi);
            prosjek = Objekt.Prosjek(Brojevi);
            Console.WriteLine("Zbroj brojeva je : " + zbroj + " a prosjek brojeva je : " + prosjek);
            Console.ReadKey();
        }
    }
}
