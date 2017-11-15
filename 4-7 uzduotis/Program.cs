using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4_7_uzduotis
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("kokia temperatura laipsniais?");
            var c = Convert.ToInt32(Console.ReadLine());
            var f = c * 9 / 5 + 32;
            var k = c + 273.15;
            Console.WriteLine("f: " + f);
            Console.WriteLine("k: " + k);
        }
    }
}
