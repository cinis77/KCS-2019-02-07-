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
            for (int i = 0; i < masyvas.Length; i++)
            {
                suma += masyvas[i];
                if ((masyvas[i] % 2) != 0)
                {
                    sandauga *= masyvas[i];
                }
            }
            Console.WriteLine("Masyvo suma yra: " + suma);
            Console.WriteLine("Masyvo vidurkis yra: " + ((double)suma / masyvas.Length));
            Console.WriteLine("Nelyginiu skaiciu sandauga yra: " + sandauga);
        }
    }
}