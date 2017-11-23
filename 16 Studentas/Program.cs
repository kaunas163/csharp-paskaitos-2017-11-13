using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace _16_Studentas
{
    class Program
    {
        static void Main(string[] args)
        {
            var studentas = new Studentas("Haris", "Poteris", "Floperis ryzas", 113,
                new List<int>
                {
                    7, 8, 9, 6, 3
                }, new List<int>
                {
                    4, 7, 5, 8, 9, 10
                }, new List<int>
                {
                    10, 10, 9, 2
                });

            studentas.Isvedimas();
        }
    }
}
