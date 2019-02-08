using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SkaiciavimoMasinele
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine("Iveskite skaiciu");
            int sk1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Iveskite zenkla");
            char zenklas = Console.ReadKey().KeyChar;
            Console.WriteLine("\nIveskite skaiciu");
            int sk2 = Convert.ToInt32(Console.ReadLine());
            if (zenklas == '+')
            {
                var suma = sk1 + sk2;
                Console.WriteLine("Atsakymas yra suma: " + suma);
            }
            else if (zenklas == '-')
            {
                var skirtumas = sk1 - sk2;
                Console.WriteLine("Atsakymas yra: " + skirtumas);
            }
            else if (zenklas == '*')
            {
                var sandauga = sk1 * sk2;
                Console.WriteLine("Atsakymas yra: " + sandauga);
            }
            else if (zenklas == '/')
            {
                if (sk2 != 0)
                {
                    var dalmuo = (double)sk1 / sk2;
                    Console.WriteLine("Atsakymas yra: " + dalmuo);
                }
                else
                {
                    Console.WriteLine("Dalyba is 0 negalima");
                }
            }
            else
            {
                Console.WriteLine("Ivestas netinkamas zenkals");
            }
        }
    }
}