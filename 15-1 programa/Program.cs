using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _15_1_programa
{
    class Program
    {
        static void Main(string[] args)
        {
            List<double> atlyginimai = new List<double>();
            var programa = new Program();
            programa.Ivedimas(atlyginimai);
            programa.Isvedimas(atlyginimai);

            Console.WriteLine("Mažiausia alga: " + programa.MaziausiaAlga(atlyginimai));
            Console.WriteLine("Didžiausia alga: " + programa.DidziausiaAlga(atlyginimai));
            Console.WriteLine("Vidutinė alga: " + programa.VidutineAlga(atlyginimai));
            Console.WriteLine("Daugiau už vidurkį: " + programa.DaugiauUzVidurki(atlyginimai));
        }

        public void Ivedimas(List<double> atlyginimai)
        {
            /* 1. paklaust kiek atlyginimų norima suvesti
             * 2. sukti ciklą nuo 0 iki nurodyto kiekio
             * 2. 1. cikle išvesti "iveskite i-aji skaiciu"
             * 2. 2. įvesti ir įkelti į sąrašą skaičių */

            Console.WriteLine("Kiek atlyginimų suvesti?");
            var kiek = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < kiek; i++)
            {
                Console.Write("įveskite {0}-ajį skaičių: ", i+1);
                atlyginimai.Add(Convert.ToDouble(Console.ReadLine()));
            }
        }

        public void Isvedimas(List<double> atlyg)
        {
            foreach (var atl in atlyg)
            {
                Console.Write("[{0}] ", atl);
            }

            Console.WriteLine();
        }

        public double MaziausiaAlga(List<double> atlyginimai)
        {
            return atlyginimai.Min();
        }

        public double DidziausiaAlga(List<double> atlyginimai)
        {
            return atlyginimai.Max();
        }

        public double VidutineAlga(List<double> atlyginimai)
        {
            return atlyginimai.Average();
        }

        // randame kiek algų yra daugiau už vidurkį

        public int DaugiauUzVidurki(List<double> atlyginimai)
        {
            var vidurkis = VidutineAlga(atlyginimai);
            var kiekis = 0;

            foreach (var atlyginimas in atlyginimai)
            {
                if (atlyginimas > vidurkis)
                {
                    kiekis++;
                }
            }

            return kiekis;
        }

        // rasti kiek algų buvo virš 1500 €



        // rasti tris didžiausias algas



        // rasti penktą didžiausią algą
    }
}
