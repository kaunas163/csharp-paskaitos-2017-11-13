using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12_4_uzduotis
{
    class Program
    {
        static void Main(string[] args)
        {
            /*var tekstas = "";

            tekstas += "zodis";
            tekstas += "tekstas";

            Console.WriteLine(tekstas);*/

            var rezultatas = "";
            var ivedimas = "";

            while (ivedimas != "exit") // kol neivede exit
            {
                Console.Write("iveskite zodi arba exit: ");
                ivedimas = Console.ReadLine();

                if (ivedimas != "exit")
                {
                    rezultatas += ivedimas + " ";
                }
            }
            Console.WriteLine(rezultatas);
        }
    }
}
