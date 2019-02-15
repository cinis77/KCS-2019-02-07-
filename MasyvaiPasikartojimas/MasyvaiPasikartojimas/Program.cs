using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MasyvaiPasikartojimas
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            int[] masyvas = { 1, 20, 80, -100, 1000, 400, 500, 9 };
            int suma = 0;
            int sandauga = 1;

            foreach (var item in masyvas)
            {
                suma += item;
                if ((item % 2) != 0)
                {
                    sandauga *= item;
                }
            }

            Console.WriteLine("Masyvo suma yra: " + suma);
            Console.WriteLine("Masyvo vidurkis yra: " + ((double)suma / masyvas.Length));
            Console.WriteLine("Nelyginiu skaiciu sandauga yra: " + sandauga);
        }
    }
}