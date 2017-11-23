using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _16_masinos
{
    class Program
    {
        static void Main(string[] args)
        {
            var automobilis = new Automobilis("Audine", "A4", 2017, 2.2, 150, 3);
            automobilis.Isvedimas();

            var automobiliai = new List<Automobilis>
            {
                new Automobilis("hshs", "hsdhbg", 2000, 2.1, 20, 50),
                new Automobilis("safsdg", "sdgdg", 2010, 1.8, 200, 10),
                new Automobilis("aafsf", "dsdg", 2018, 3.0, 300, 0),
                new Automobilis("asf", "dgfg", 1999, 1.6, 80, 200000),
            };

            var programa = new Program();
            programa.Isvedimas(automobiliai);

            var naujausias = programa.NaujausiasAuto(automobiliai);
            Console.WriteLine("Naujausias auto:");
            naujausias.Isvedimas();

        } // main metodo pabaiga

        // visa automobiliu sarasa isvesti i ekrana
        public void Isvedimas(List<Automobilis> automobiliai)
        {
            foreach (var auto in automobiliai)
            {
                auto.Isvedimas();
            }
        }

        // naujausias automobilis
        public Automobilis NaujausiasAuto(List<Automobilis> automobiliai)
        {
            /* 1. laikinas objektas, lygus pirmam nariui is saraso, cia bus atsakymas ir su situ objektu viska lyginsim
             * 2. eina per automobiliu sarasa
             * 2. 1. tikrinam ar dabartinis auto.metai yra naujesnis nei laikino objekto.metai
             * 2. 1. 1. prisiskiriam nauja reiksme jei taip
             * 3. grazinam gauta atsakyma
             */

            var laikinas = automobiliai.First();

            foreach (var auto in automobiliai)
            {
                if (auto.Metai > laikinas.Metai)
                {
                    laikinas = auto;
                }
            }

            return laikinas;
        }

        // rasyti metodus:
        //  seniausias automobilis
        //  didziausios galios automobilis
        //  maziausiai nuvaziaves automobilis

    } // class Program pabaiga
}
