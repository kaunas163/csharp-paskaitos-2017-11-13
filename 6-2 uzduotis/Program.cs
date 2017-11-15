using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6_2_uzduotis
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("iveskite rezultata");
            var rez = Convert.ToInt32(Console.ReadLine());

            if (rez == 100)
            {
                Console.WriteLine("100");
            }
            else if (rez >= 80)
            {
                Console.WriteLine("80-100");
            }
            else if (rez >= 50)
            {
                Console.WriteLine("50-80");
            }
            else if (rez >= 20)
            {
                Console.WriteLine("20-50");
            }
            else if (rez < 20)
            {
                Console.WriteLine("< 20");
            }
        }
    }
}
