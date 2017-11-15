using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4_2_uzduotis
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("iveskite simboli");
            var kazkas = Console.ReadLine();

            Console.WriteLine(kazkas + kazkas + kazkas);
            Console.WriteLine(kazkas + kazkas + kazkas);
            Console.WriteLine(kazkas + kazkas + kazkas);

            Console.WriteLine("{0}{0}{0}", kazkas);
            Console.WriteLine("{0}{0}{0}", kazkas);
            Console.WriteLine("{0}{0}{0}", kazkas);

            Console.WriteLine("{0}{0}{0}\n{0}{0}{0}\n{0}{0}{0}", kazkas);
        }
    }
}
