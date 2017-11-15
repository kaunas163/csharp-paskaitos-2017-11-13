using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4_4_uzduotis
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("iveskite tris skaicius");
            var a = Convert.ToInt32(Console.ReadLine());
            var b = Convert.ToInt32(Console.ReadLine());
            var c = Convert.ToInt32(Console.ReadLine());

            var suma = a + b + c;
            var skirtumas = a - b - c;
            var sandauga = a * b * c;
            var dalmuo = a / b / c;

            Console.WriteLine("{0} + {1} + {2} = {3}",
                a, b, c, suma);
            Console.WriteLine("{0} - {1} - {2} = {3}",
                a, b, c, skirtumas);
            Console.WriteLine("{0} * {1} * {2} = {3}",
                a, b, c, sandauga);
            Console.WriteLine("{0} / {1} / {2} = {3}",
                a, b, c, dalmuo);
        }
    }
}
