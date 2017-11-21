using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _15_2_primilziai
{
    class Program
    {
        static void Main(string[] args)
        {
            List<double> primilziai = new List<double>();
            
            var programa = new Program();
            programa.Ivedimas(primilziai);
            programa.Isvedimas(primilziai);

            Console.WriteLine("Maziausias: " + programa.Maziausias(primilziai));
            Console.WriteLine("Didziausias: " + programa.Didziausias(primilziai));
            Console.WriteLine("Vidutinis: " + programa.Vidutinis(primilziai));
        }

        // įvedimo metodas

        public void Ivedimas(List<double> primilziai)
        {
            Console.WriteLine("iveskite primilziu kieki:");
            var kiek = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < kiek; i++)
            {
                Console.Write("iveskite: ");
                primilziai.Add(Convert.ToDouble(Console.ReadLine()));
            }
        }

        // išvedimo metodas

        public void Isvedimas(List<double> primilziai)
        {
            foreach (var primilzis in primilziai)
            {
                Console.WriteLine(primilzis + " l");
            }
        }

        // min, max, average metodai

        public double Maziausias(List<double> primilziai)
        {
            return primilziai.Min();
        }

        public double Didziausias(List<double> primilziai)
        {
            return primilziai.Max();
        }

        public double Vidutinis(List<double> primilziai)
        {
            return primilziai.Average();
        }

        // rasti du didziausius primilzius
    }
}
