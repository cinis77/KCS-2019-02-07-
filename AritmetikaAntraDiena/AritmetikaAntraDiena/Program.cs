using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AritmetikaAntraDiena
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine("Iveskite skaiciu");
            int sk1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Iveskite skaiciu");
            int sk2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Dalybos atsakymas: " + ((double)sk1 / sk2));
            Console.WriteLine("Sveikoji dalis: " + (sk1 / sk2));
            Console.WriteLine("Liekana yra: " + (sk1 % sk2));
        }
    }
}