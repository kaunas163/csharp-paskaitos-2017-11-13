using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _16_pavyzdziai
{
    class Program
    {
        static void Main(string[] args)
        {
            var knyga1 = new Knyga(); // objektas
            knyga1.Pavadinimas = "Haris floperis";
            knyga1.Autorius = "Anonimas";
            knyga1.Metai = 1816;
            knyga1.PuslapiuSkaicius = 12;
            knyga1.Isvedimas();

            var knyga2 = new Knyga("Voldemorto nuotykiai", "Jis", 12, 1817);
            knyga2.Isvedimas();

            var knygos = new List<Knyga>
            {
                new Knyga("kaip ismokt programuot", "Koks cia kauderis", 1000000, -1561),
                new Knyga("anyksciu silelis", "A. Baranauskas", 531, 2017),
                new Knyga("Haris Poteris", "J. K. Rowling", 350, 2007)
            };

            foreach (var knyga in knygos)
            {
                knyga.Isvedimas();
            }
        }
    }
}
