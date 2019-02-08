using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrikampiuPaieska
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine("Iveskite skaiciu");
            int sk1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Iveskite skaiciu");
            int sk2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Iveskite skaiciu");
            int sk3 = Convert.ToInt32(Console.ReadLine());
            if ((sk1 + sk2) > sk3)
            {
                if ((sk2 + sk3) > sk1)
                {
                    if ((sk1 + sk3) > sk2)
                    {
                        Console.WriteLine("Trikampi sudarytis gamlima");
                    }
                    else
                    {
                        Console.WriteLine("Trikampio sudaryti negalima");
                    }
                }
                else
                {
                    Console.WriteLine("Trikampio sudaryti negalima");
                }
            }
            else
            {
                Console.WriteLine("Trikampio sudaryti negalima");
            }

            if ((sk2 + sk3) > sk1 && (sk1 + sk2) > sk3 && (sk1 + sk3) > sk2)
            {
                Console.WriteLine("Trikampi sudarytis gamlima");
            }
        }
    }
}