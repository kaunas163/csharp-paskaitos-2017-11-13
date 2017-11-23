using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _16_Parduotuve
{
    class Preke
    {
        public string Pavadinimas { get; private set; }
        public string Kodas { get; private set; }
        public double Kaina { get; private set; }
        public double Savikaina { get; private set; }
        public int Kiekis { get; private set; }

        public Preke(string pavadinimas, string kodas, double kaina, double savikaina, int kiekis)
        {
            Pavadinimas = pavadinimas;
            Kodas = kodas;
            Kaina = kaina;
            Savikaina = savikaina;
            Kiekis = kiekis;
        }

        public void Isvedimas()
        {
            Console.WriteLine("Prekė: {0} {1}", Pavadinimas, Kodas);
            Console.WriteLine("Kaina/savikaina: {0} / {1}", Kaina, Savikaina);
            Console.WriteLine("Prekės kiekis: " + Kiekis);
            Console.WriteLine();
        }

        public double PelnasIsPrekes()
        {
            return Kaina - Savikaina;
        }

        public double PelnasPardavusVisaKieki()
        {
            return PelnasIsPrekes() * Kiekis;
        }
    }
}
