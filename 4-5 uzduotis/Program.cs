using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4_5_uzduotis
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("iveskite sveikaji skaiciu");
            var skaicius = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("{0} * {1} = {2}",
                skaicius, 1, skaicius * 1);
            Console.WriteLine("{0} * {1} = {2}",
                skaicius, 2, skaicius * 2);
            Console.WriteLine("{0} * {1} = {2}",
                skaicius, 3, skaicius * 3);
            Console.WriteLine("{0} * {1} = {2}",
                skaicius, 4, skaicius * 4);
            Console.WriteLine("{0} * {1} = {2}",
                skaicius, 5, skaicius * 5);

            var daugiklis = 1;

            Console.WriteLine("{0} * {1} = {2}",
                skaicius, daugiklis, skaicius * daugiklis++);
            Console.WriteLine("{0} * {1} = {2}",
                skaicius, daugiklis, skaicius * daugiklis++);
            Console.WriteLine("{0} * {1} = {2}",
                skaicius, daugiklis, skaicius * daugiklis++);
            Console.WriteLine("{0} * {1} = {2}",
                skaicius, daugiklis, skaicius * daugiklis++);
            Console.WriteLine("{0} * {1} = {2}",
                skaicius, daugiklis, skaicius * daugiklis++);
        }
    }
}
