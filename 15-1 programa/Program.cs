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
    }
}
