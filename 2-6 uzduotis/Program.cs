using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_6_uzduotis
{
    class Program
    {
        static void Main(string[] args)
        {
            var marke = "audi";
            var modelis = "a6";
            var metai = 2017;
            var rida = 300000;

            Console.WriteLine("Automobilio {0} {1} ({2} m.) rida - {3} km.", marke, modelis, metai, rida);
        }
    }
}
