using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sarasai
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            List<int> PazymiuSarasas = new List<int>();
            Console.WriteLine("Kiek norite ivesti pazymiu?");
            int kiekis = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Veskite pazymius");
            for (int i = 0; i < kiekis; i++)
            {
                PazymiuSarasas.Add(Convert.ToInt32(Console.ReadLine()));
            }
            Console.WriteLine("Didziausias skaicius yra: " + PazymiuSarasas.Max());
            Console.WriteLine("Maziausias skaicius yra: " + PazymiuSarasas.Min());
            Console.WriteLine("Vidurkis yra: " + PazymiuSarasas.Average());
            Console.WriteLine("Pirmas ivestas skaicius yra: " + PazymiuSarasas.First());
            Console.WriteLine("Paskutinis ivestas skaicius yra: " + PazymiuSarasas.Last());
            Random rng = new Random(); //Random Number generator
            var skaicius = rng.Next();
            var skaiciusApribotas = rng.Next(-10, 10);
        }
    }
}