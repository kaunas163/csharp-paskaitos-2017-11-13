using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5_1_uzduotis
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("iveskite tris skaicius");
            var a = Convert.ToInt32(Console.ReadLine());
            var b = Convert.ToInt32(Console.ReadLine());
            var c = Convert.ToInt32(Console.ReadLine());

            if (a == b)
            {
                Console.WriteLine("a=b");
            }

            if (b == c)
            {
                Console.WriteLine("b=c");
            }

            if (a > b)
            {
                Console.WriteLine("a > b");
            }

            if (b > c * 2)
            {
                Console.WriteLine("b > c * 2");
            }

            if (a % 2 == 0)
            {
                Console.WriteLine("a % 2 == 0");
            }

            if (b % 2 != 0)
            {
                Console.WriteLine("b % 2 != 0");
            }

            if (c > 0)
            {
                Console.WriteLine("c > 0");
            }

            if (c < 0)
            {
                Console.WriteLine("c < 0");
            }
        }
    }
}
