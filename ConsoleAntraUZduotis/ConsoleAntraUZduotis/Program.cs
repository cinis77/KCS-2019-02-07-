using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAntraUZduotis
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine("Iveskite varda");
            string Varda = Console.ReadLine();
            Console.WriteLine("Megiamiausios spalvos pirma raide");
            char raide = Console.ReadKey().KeyChar;
            Console.WriteLine("\nIveskite atsitiktini sveika skaiciu");
            int sk1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Iveskite atsitiktini sveika skaiciu");
            int sk2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Jusu vardas yra: {0}, megiamiausia"
                + " spalva yra {1}, atsitiktiniai skaiciai {2} ir {3}"
                , Varda, raide, sk1, sk2);
        }
    }
}