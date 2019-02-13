using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetodaiAntraUZduotis
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Pasisveikinimas();
            Console.WriteLine("Iveskite savo varda");
            string vardas = Console.ReadLine();
            Console.WriteLine("IVeskite savo amziu");
            int amzius = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Iveskite savo hobi");
            string hobis = Console.ReadLine();
            FormatuosAtsakyma(vardas, amzius, hobis);
        }

        public static void Pasisveikinimas()
        {
            Console.WriteLine("Sveiki Vartotojau");
        }

        /// <summary>
        /// Suformatuoja ivesta teksta
        /// </summary>
        /// <param name="vardas"></param>
        /// <param name="amzius"></param>
        /// <param name="hobi"></param>
        public static void FormatuosAtsakyma(string vardas, int amzius, string nesamone)
        {
            Console.WriteLine("Jusu vardas yra: " + vardas);
            Console.WriteLine("Jusu amzius yra: " + amzius);
            Console.WriteLine("Jusu hobi yra: " + nesamone);
        }
    }
}