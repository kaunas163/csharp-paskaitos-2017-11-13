using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14_3_uzduotis
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> zodziai = new List<string>
            {
                "dramblys",
                "zirafa",
                "strutis",
                "liutas",
                "monstras"
            };

            var trumpiausias = zodziai[0];
            var ilgiausias = zodziai[0];

            foreach (var zodis in zodziai)
            {
                if (zodis.Length < trumpiausias.Length)
                {
                    trumpiausias = zodis;
                }
            }

            Console.WriteLine("trumpiausias: " + trumpiausias.Length);
        }
    }
}
