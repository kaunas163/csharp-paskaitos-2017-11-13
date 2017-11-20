using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14_2_uzduotis
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> pazymiai = new List<int>();

            Console.WriteLine("kiek pazymiu norite ivesti");
            var kiek = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < kiek; i++)
            {
                Console.Write("iveskite {0} skaiciu: ", i+1);
                pazymiai.Add(Convert.ToInt32(Console.ReadLine()));
            }

            var rnd = new Random();
            Console.WriteLine("didziausias: " + pazymiai.Max());
            Console.WriteLine("maziausias: " + pazymiai.Min());
            Console.WriteLine("vidurkis: " + pazymiai.Average());
            Console.WriteLine("atsitiktinis: " + pazymiai[rnd.Next(pazymiai.Count)]);
        }
    }
}
