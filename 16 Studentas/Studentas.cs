using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _16_Studentas
{
    class Studentas
    {
        public string Vardas { get; private set; }
        public string Pavarde { get; private set; }
        public string Pravarde { get; private set; }
        public int Amzius { get; private set; }
        public List<int> MatematikosPazymiai { get; private set; }
        public List<int> InformatikosPazymiai { get; private set; }
        public List<int> BiologijosPazymiai { get; private set; }

        public Studentas(string vardas, string pavarde, string pravarde, int amzius, List<int> matematikosPazymiai, List<int> informatikosPazymiai, List<int> biologijosPazymiai)
        {
            Vardas = vardas;
            Pavarde = pavarde;
            Pravarde = pravarde;
            Amzius = amzius;
            MatematikosPazymiai = matematikosPazymiai;
            InformatikosPazymiai = informatikosPazymiai;
            BiologijosPazymiai = biologijosPazymiai;
        }

        public void Isvedimas()
        {
            Console.WriteLine("Studentas: {0} {1} ({2} m.)", Vardas, Pavarde, Amzius);
            Console.WriteLine("Turi {0} pravarde.", Pravarde);
            Console.WriteLine("Matematikos pazymiai:");
            foreach (var i in MatematikosPazymiai)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();
            Console.WriteLine("Informatikos pazymiai:");
            foreach (var i in InformatikosPazymiai)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();
            Console.WriteLine("Biologijos pazymiai:");
            foreach (var i in BiologijosPazymiai)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();

            Console.WriteLine("Visų pažymių vidurkis: " + Math.Round(Vidurkis(), 2));
            Console.WriteLine("Didžiausias pažymys: " + DidziausiasPazymys());
        }

        public double Vidurkis()
        {
            return (MatematikosPazymiai.Average() + InformatikosPazymiai.Average() + BiologijosPazymiai.Average()) / 3;
        }

        public int DidziausiasPazymys()
        {
            var pirmas = MatematikosPazymiai.Max();
            var antras = InformatikosPazymiai.Max();
            var trecias = BiologijosPazymiai.Max();

            if (pirmas > antras && pirmas > trecias)
            {
                return pirmas;
            }
            else if (antras > pirmas && antras > trecias)
            {
                return antras;
            }
            else if (trecias > pirmas && trecias > antras)
            {
                return trecias;
            }
            return pirmas; // skaiciai lygus, grazina bet kuri
        }
    }
}
