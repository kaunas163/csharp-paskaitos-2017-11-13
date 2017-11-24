using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _17_pavyzdziai
{
    class Policininkas : Darbuotojas
    {
        public double Kysis { get; private set; }
        public int KiekSuemeNusikalteliu { get; private set; }

        public Policininkas(string vardas, string pavarde, int amzius, double alga, double etatas, double kysis, int kiekSuemeNusikalteliu)
            : base(vardas, pavarde, amzius, alga, etatas)
        {
            Kysis = kysis;
            KiekSuemeNusikalteliu = kiekSuemeNusikalteliu;
        }

        public void Isvedimas()
        {
            base.Isvedimas();
            Console.WriteLine("Gauna kysio: " + Kysis);
            Console.WriteLine("Sugavo nusikalteliu: " + KiekSuemeNusikalteliu);
            Console.WriteLine();
        }
    }
}
