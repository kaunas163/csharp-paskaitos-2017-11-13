using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7_2_uzduotis
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("iveskite du skaicius");
            var a = Convert.ToInt32(Console.ReadLine());

            if (a < 0)
            {
                Console.WriteLine(a + " neigiamas");
            }
            else if (a > 0)
            {
                Console.WriteLine(a + " teigiamas");
            }
            else
            {
                Console.WriteLine("skaicius yra nulis");
            }
        }
    }
}
