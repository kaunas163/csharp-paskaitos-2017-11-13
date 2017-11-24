using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _17_pavyzdziai
{
    class Program
    {
        static void Main(string[] args)
        {
            var darbuotojas = new Darbuotojas("ajfb", "jsd", 20, 500, 1);
            darbuotojas.Isvedimas();
            Console.WriteLine();

            var policininkas = new Policininkas("afb", "sjdbg", 30, 600, 1, 100, 20);
            policininkas.Isvedimas();
        }
    }
}
