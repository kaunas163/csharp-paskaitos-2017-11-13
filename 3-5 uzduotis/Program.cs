using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_5_uzduotis
{
    class Program
    {
        static void Main(string[] args)
        {
            var skaicius = 5;
            var daugiklis = 0;

            Console.WriteLine("{0} * {1} = {2}", skaicius, daugiklis, skaicius * daugiklis++);
            Console.WriteLine("{0} * {1} = {2}", skaicius, daugiklis, skaicius * daugiklis++);
            Console.WriteLine("{0} * {1} = {2}", skaicius, daugiklis, skaicius * daugiklis++);
            Console.WriteLine("{0} * {1} = {2}", skaicius, daugiklis, skaicius * daugiklis++);
        }
    }
}
