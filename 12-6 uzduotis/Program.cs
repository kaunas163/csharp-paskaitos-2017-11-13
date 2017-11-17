using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12_6_uzduotis
{
    class Program
    {
        static void Main(string[] args)
        {
            var rnd = new Random();
            var slaptas = rnd.Next(1, 11); // [1-10)
            var spejimas = 0;

            while (spejimas != slaptas)
            {
                Console.WriteLine("spekite skaiciu 1-10");
                spejimas = Convert.ToInt32(Console.ReadLine());

                if (slaptas > spejimas)
                {
                    Console.WriteLine("slaptas skaicius didesnis");
                }
                else if (slaptas < spejimas)
                {
                    Console.WriteLine("slaptas skaicius mazesnis");
                }
                else
                {
                    Console.WriteLine("jus laimejote!");
                }
            }
        }
    }
}
