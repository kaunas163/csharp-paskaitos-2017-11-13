using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _16_pakartojimas
{
    class Program
    {
        static void Main(string[] args)
        {
            // KINTAMIEJI

            // tipas pavadinimas = reiksme;

            // deklaracija
            int ashfb;
            
            // inicializacija
            ashfb = 5;

            // int doube float short long byte string char.....

            string jsg = "aaaaaa"; // char masyvas
            Console.WriteLine(jsg[1]); // b
            Console.WriteLine(jsg.Length); // 4

            // IŠVEDIMAS

            Console.WriteLine("jabfhj");
            Console.WriteLine("asdgjfh" + jsg);
            Console.WriteLine(jsg);
            Console.WriteLine("jshdfh {0} jhbdhfg", jsg);
            Console.WriteLine("jsfhd\njshdfhg");
            Console.WriteLine("sdhf {0} " + "shfbdh", jsg);

            // ĮVEDIMAS

            var tekstas = Console.ReadLine();
            var skaicius = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("iveskite x: " + Console.ReadLine());

            var shjg = int.Parse("25");
            var skaicius2 = int.Parse(Console.ReadLine());

            // apsisaugoti nuo blogo ivedimo

            int asss;
            var bbbb = Console.ReadLine();
            var pavyko = int.TryParse(bbbb, out asss);
            if (pavyko)
            {
                // atlikti skaiciavimus
            }
            else
            {
                // rekti ant vartotojo
            }

            // convert - iš visko į viską
            // parse - iš teksto į kažką

            Console.WriteLine("iveskite raide:");
            var raide = (char)Console.Read();
            Console.WriteLine(raide);

            // ARITMETINIAI VEIKSMAI

            // * / + - % ()

            var jhdshd = 55 + 899;
            var shdgb = jhdshd - 554;
            var fdf = 8 * 9;
            // ....

            var bbfdj = 2 * (5 - 3) + 8;

            var aaaa = 4 / 7; // 0
            var aaaaaf = (double)4 / 7; // 0,....

            var oppp = 5;
            Console.WriteLine(oppp++); // isveda 5, padideja
            Console.WriteLine(oppp); // 6
            Console.WriteLine(oppp++); // isveda 6, padideja
            Console.WriteLine(oppp++); // isveda 7, padideja
            Console.WriteLine(oppp); // isveda 8

            var ttt = 5;
            Console.WriteLine(++ttt); // isveda 6
            Console.WriteLine(ttt); // 6
            Console.WriteLine(ttt); // 6
            Console.WriteLine(++ttt); // 7
            Console.WriteLine(ttt); // 7
            Console.WriteLine(++ttt); // 8
            Console.WriteLine(ttt); // 8

            Console.WriteLine(-4 * -8);

            // IF SĄLYGA

            if (5 > 3)
            {
                // true
            }

            if (8 * 3 > 0)
            {
                // true
            }

            if (9 - 7 > 100)
            {
                // false
            }

            if (8 / 2 * 3 == 0)
            {
                // false
            }

            if (5 != 0)
            {
                // true
            }

            if ((7 * 2 > 20) && (5 - 3 > -2))
            {
                // false
            }

            if ((7 * 50 > 20) && (5 - 3 > -2))
            {
                // true
            }

            if ((7 * 2 > 20) || (5 - 3 > -2))
            {
                // true
            }

            // && - ir - viskas turi buti teisinga
            // || - arba - bent vienas turi buti teisingas

            // CIKLAS FOR

            for (int i = 0; i < 1; i++)
            {
                Console.WriteLine(i);
            }

            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine(i);
            }

            for (int i = 0; i <= 5; i += 2)
            {
                Console.WriteLine(i);   
            }

            for (int i = 5; i > 0; i--)
            {
                Console.WriteLine(i);
            }

            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine(i + " " + i * i);
            }

            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Console.WriteLine(i + " " + j);
                }
            }

            /* 0 0
             * 0 1
             * 0 2
             * 1 0
             * 1 1
             * 1 2
             * 2 0
             * 2 1
             * 2 2
             */

            /*for (;;) // begalinis ciklas
            {
                Console.WriteLine("labas ");
            }*/

            // CIKLAS WHILE

            /*while (true) // begalinis ciklas
            {
                Console.WriteLine("labas ");
            }*/

            /*while (5 > 3) // begalinis ciklas
            {
                Console.WriteLine("labas ");
            }*/

            var kjfnj = 0;
            while (kjfnj < 10)
            {
                Console.WriteLine(kjfnj);
                kjfnj++;
            }

            var ooiaj = 0;
            while (true)
            {
                if (ooiaj > 10)
                {
                    break;
                }

                Console.WriteLine(ooiaj);
                ooiaj++;
            }

            var hs = 0;
            while (true)
            {
                hs++;
                if (hs == 2)
                {
                    continue; // grizta i ciklo pradzia
                }
                if (hs > 5)
                {
                    break; // nutraukia cikla visai
                }
                Console.WriteLine(hs);
            }

            // MASYVAI IR SARASAI

            var hhfbh = new [] {4, 5, 8, 9, 10, 2};
            Console.WriteLine(hhfbh[0]); // 4
            Console.WriteLine(hhfbh[2]); // 8
            Console.WriteLine(hhfbh[4]); // 10
            Console.WriteLine(hhfbh[1]); // 5
            Console.WriteLine(hhfbh.Last()); // 2
            Console.WriteLine(hhfbh.Max()); // 10
            Console.WriteLine(hhfbh[hhfbh.Length-2]); // 10
            
            List<int> jhshdbh = new List<int>{8, 7, 7, 3, 5};
            Console.WriteLine(jhshdbh.Count); // 5
            jhshdbh.Sort();
            Console.WriteLine();
            foreach (var i in jhshdbh)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine();

            // KLASĖ

            var klasesobjektas = new klase();
            Console.WriteLine(klasesobjektas.objektas.skaicius);
        }
    }
}
