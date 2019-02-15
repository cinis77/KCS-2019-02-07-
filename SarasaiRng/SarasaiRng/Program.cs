using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SarasaiRng
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Random rng = new Random();
            List<int> Sarasas = new List<int>();
            for (int i = 0; i < rng.Next(1, 500000); i++)
            {
                Sarasas.Add(rng.Next(-60000, 60000));
            }
            Console.WriteLine("Kiekis: " + Sarasas.Count);
            Console.WriteLine("Max reiksme: " + Sarasas.Max());
            Console.WriteLine("Min reiksme: " + Sarasas.Min());
            Console.WriteLine("Vidurkis: " + Sarasas.Average());
            Console.WriteLine("Pirmas elementas: " + Sarasas.First());
            Console.WriteLine("Paskutinis elementas: " + Sarasas.Last());
            double nelyginiaiSuma = 0;
            int kiekisNelyginiai = 0;
            foreach (var item in Sarasas)
            {
                if ((item % 2) != 0)
                {
                    nelyginiaiSuma += item;
                    kiekisNelyginiai++;
                }
            }
            Console.WriteLine("Suma nelyginiu skaiciu" + nelyginiaiSuma);
            Console.WriteLine("Kiekis nelyginiu skaiciu: " + kiekisNelyginiai);
            Console.WriteLine("Suma nelyginiu skaiciu: " + Sarasas.Where(x => (x % 2) != 0).Sum());
            Console.WriteLine("Suma nelyginiu skaiciu: " + Sarasas.Where(x => (x % 2) != 0).Count());
        }
    }
}