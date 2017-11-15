using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_6_uzduotis
{
    class Program
    {
        static void Main(string[] args)
        {
            var a = 78;
            var pirmas = a / 10; // 2
            var antras = a % 10; // 5
//            Console.WriteLine("pirmas: " + pirmas);
//            Console.WriteLine("antras: " + antras);
            Console.WriteLine(pirmas * antras);
        }
    }
}
