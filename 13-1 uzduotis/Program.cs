using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13_1_uzduotis
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] pazymiai = {7, 8, 3, 9, 10};

            var markes = new string[3];
            markes[0] = "audi";
            markes[1] = "lada";
            markes[2] = "kamaz";

            Console.WriteLine("masyvu dydziai");
            Console.WriteLine("pazymiai: " + pazymiai.Length);
            Console.WriteLine("markes: " + markes.Length);

            Console.WriteLine("pazymiu masyvo");
            Console.WriteLine("pirma reiksme: " + pazymiai.First());
            Console.WriteLine("paskutine reiksme: " + pazymiai.Last());

            var skaiciai = new int[5];
            Console.WriteLine("iveskite penkis skaicius");

            for (int i = 0; i < 5; i++)
            {
                Console.Write(i + 1 + ": ");
                skaiciai[i] = Convert.ToInt32(Console.ReadLine());
            }
        }
    }
}
