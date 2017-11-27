using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _18_2_darbas_su_failu
{
    public class Darbuotojas
    {
        public string Vardas { get; private set; }
        public string Pavarde { get; private set; }
        public int Amzius { get; private set; }
        public string Pareigos { get; private set; }
        public double Alga { get; private set; }

        public Darbuotojas(string vardas, string pavarde, int amzius, string pareigos, double alga)
        {
            Vardas = vardas;
            Pavarde = pavarde;
            Amzius = amzius;
            Pareigos = pareigos;
            Alga = alga;
        }
    }
}
