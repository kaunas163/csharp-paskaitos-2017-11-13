using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14_1_uzduotis
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> skaiciai = new List<int>();

            // atsitiktiniu skaiciu generavimui
            var rnd = new Random();

            // kiek skaiciu noresime sugeneruoti
            var kiekSugeneruoti = rnd.Next(1, 101); // [1-100]

            // sudedam norima kieki atsitiktiniu skaiciu
            for (int i = 0; i < kiekSugeneruoti; i++)
            {
                // generuojam atsitiktini skaiciu ir ji dedam
                // i sarasa
                skaiciai.Add(rnd.Next(1, 101));

                // isvedam katik ideta skaiciu
                Console.Write(skaiciai[i] + " ");
            }

            Console.WriteLine("maziausias skaicius: " + skaiciai.Min());
            Console.WriteLine("didziausias skaicius: " + skaiciai.Max());

            var vidurkis = skaiciai.Average();
            Console.WriteLine("vidurkis: " + vidurkis);

            var zemesniuUzVidurki = 0;

            foreach (var skaicius in skaiciai)
            {
                if (skaicius < vidurkis)
                {
                    zemesniuUzVidurki++;
                }
            }
        }
    }
}
