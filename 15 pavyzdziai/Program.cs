using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace _15_pavyzdziai
{
    class Program
    {
        static void Main(string[] args)
        {
            var programa = new Program();
            programa.Pasisveikinti();
            programa.Pasisveikinti("Ieva");
            programa.Pasisveikinti("Ieva", "Jaksaityte");
            programa.Atsisveikinti();
            programa.Atsisveikinti("Ieva");
            programa.Atsisveikinti("Ieva", "Jaksaityte");
            StatinisMetodas();

            var sumosats = programa.Suma(4, 5);
            Console.WriteLine(sumosats);

            Console.WriteLine(programa.Suma(7, 5));
            Console.WriteLine(programa.Skirtumas(7, 5));
            Console.WriteLine(programa.Sandauga(7, 5));
            Console.WriteLine(programa.Dalmuo(7, 5));

            Console.WriteLine("Iveskite du skaicius:");
            var pirmas = Convert.ToInt32(Console.ReadLine());
            var antras = Convert.ToInt32(Console.ReadLine());

            var suma = programa.Suma(pirmas, antras);
            var skirtumas = programa.Skirtumas(pirmas, antras);
            var sandauga = programa.Sandauga(pirmas, antras);
            var dalmuo = programa.Dalmuo(pirmas, antras);

            Console.WriteLine("{0} + {1} = {2}", pirmas, antras, suma);
            // kitus isvedimus patys

        } // main metodo pabaigos skliaustas

        // rasysim cia
        /*
         pasiekiamumas tipas pavadinimas(parametrai)
         {
             kodas
         }
         */

        public void Pasisveikinti()
        {
            Console.WriteLine("Labas krabas");
        }

        public void Pasisveikinti(string vardas)
        {
            Console.WriteLine("Labas, " + vardas);
        }

        public void Pasisveikinti(string vardas, string pavarde)
        {
            Console.WriteLine("Labas, " + vardas + " " + pavarde);
        }

        public void Atsisveikinti()
        {
            Console.WriteLine("Ate ate");
        }

        public void Atsisveikinti(string vardas)
        {
            Console.WriteLine("Ate ate, " + vardas);
        }

        public void Atsisveikinti(string vardas, string pavarde)
        {
            Console.WriteLine("Ate ate, " + vardas + " " + pavarde);
        }

        public static void StatinisMetodas()
        {
            Console.WriteLine("statinis metodas");
        }

        public int Suma(int a, int b)
        {
            return a + b;
        }

        public int Skirtumas(int a, int b)
        {
            return a - b;
        }

        // dar apsirasyti daugybos ir dalmens metodus

        public int Sandauga(int a, int b)
        {
            return a * b;
        }

        public double Dalmuo(int a, int b)
        {
            return (double)a / b;
        }

    } // class Program skliausto pabaiga
}
