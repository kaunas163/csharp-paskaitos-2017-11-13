using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace _10_uzduotis
{
    class Program
    {
        static void Main(string[] args)
        {
            var darboValandu = 8;

            Console.WriteLine("Kiek darbuotojas gali iškepti kepalų per valandą?");
            var kepaluPerValanda = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Kiek darbuotojų turi kepykla?");
            var darbuotojai = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Vieno kepalo savikaina?");
            var savikaina = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Vieno kepalo pardavimo kaina?");
            var pardavimoKaina = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Kiek kepykla turi tą dieną užsakymų?");
            var uzsakymai = Convert.ToInt32(Console.ReadLine());

            // Suskaičiuoti kiek kepykla per vieną darbo dieną spės iškepti duonos kepalų.
            var perDienaDuonosKepalu = kepaluPerValanda * darbuotojai * darboValandu;

            Console.WriteLine("kiek kepykla per vieną darbo dieną spės iškepti duonos kepalų: " + perDienaDuonosKepalu);

            // Apskaičiuoti visų kepalų savikainą, gautas pajamas pardavus ir iš to gauto pelno dalį.
            var visuSavikaina = perDienaDuonosKepalu * savikaina;
            var visuPajamos = perDienaDuonosKepalu * pardavimoKaina;
            var pelnas = visuPajamos - visuSavikaina;

            Console.WriteLine("visu savikaina: " + visuSavikaina);
            Console.WriteLine("pajamos: " + visuPajamos);
            Console.WriteLine("pelnas: " + pelnas);

            // Patikrinti ar kepykla spės iškepti visus tos dienos užsakymus. Jei ne, suskaičiuoti kiek kepalų nespės iškepti.

            if (perDienaDuonosKepalu > uzsakymai)
            {
                Console.WriteLine("sveikiname jus ivykdete dienos norma!");
            }
            else
            {
                Console.WriteLine("jums dar truksta: " + (uzsakymai - perDienaDuonosKepalu));
            }
        }
    }
}
