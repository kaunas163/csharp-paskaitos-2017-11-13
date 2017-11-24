using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _17_pavyzdziai
{
    class Gaisrininkas : Darbuotojas
    {
        public int UzgesintiGaisrai { get; private set; }

        public Gaisrininkas(string vardas, string pavarde, int amzius, double alga, double etatas, int uzgesintiGaisrai) : base(vardas, pavarde, amzius, alga, etatas)
        {
            UzgesintiGaisrai = uzgesintiGaisrai;
        }

        public void Isvedimas()
        {
            base.Isvedimas();
            Console.WriteLine("Uzgesinti gaisrai: " + UzgesintiGaisrai);
            Console.WriteLine();
        }
    }
}
