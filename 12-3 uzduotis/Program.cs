using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12_3_uzduotis
{
    class Program
    {
        static void Main(string[] args)
        {
            var skaiciuoti = "t";

            while (skaiciuoti == "t")
            {
                Console.WriteLine("iveskite du skaicius");
                var a = Convert.ToInt32(Console.ReadLine());
                var b = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("{0} + {1} = {2}", a, b, a + b);
                Console.WriteLine("{0} - {1} = {2}", a, b, a - b);
                Console.WriteLine("{0} * {1} = {2}", a, b, a * b);
                Console.WriteLine("{0} / {1} = {2}", a, b, (double)a / b);

                Console.WriteLine("ar dar skaiciuoti? t/n");
                skaiciuoti = Console.ReadLine();
            }
        }
    }
}
