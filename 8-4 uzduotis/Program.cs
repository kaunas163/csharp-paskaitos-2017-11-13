using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8_4_uzduotis
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("iveskite du skaicius");
            var a = Convert.ToInt32(Console.ReadLine());
            var b = Convert.ToInt32(Console.ReadLine());

            // ar pirmas skaičius yra didesnis už antrąjį, arba yra lygus 0;

            if (a > b || a == 0)
            {
                Console.WriteLine("a > b || a == 0");
            }

            // ar antras skaičius yra didesnis už pirmąjį, arba yra lygus 5;

            if (b > a || b == 5)
            {
                Console.WriteLine("b > a || b == 5");
            }

            // ar pirmas skaičius yra didesnis už antrąjį ir yra lygus 20;

            if (a > b && a == 20)
            {
                Console.WriteLine("a > b && a == 20");
            }

            // ar antras skaičius yra didesnis už pirmąjį ir yra mažesnis už 100;

            if (b > a && b < 100)
            {
                Console.WriteLine("b > a && b < 100");
            }
        }
    }
}
