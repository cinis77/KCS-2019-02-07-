using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MasyvaiConsole
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            int[] masyvas = new int[10];
            for (int i = 0; i < masyvas.Length; i++)
            {
                Console.WriteLine("Iveskite skaiciu");
                masyvas[i] = Convert.ToInt32(Console.ReadLine());
            }
            int max = int.MinValue;
            int min = int.MaxValue;
            for (int i = 0; i < masyvas.Length; i++)
            {
                if (masyvas[i] < min)
                {
                    min = masyvas[i];
                }
                else if (masyvas[i] > max)
                {
                    max = masyvas[i];
                }
            }
            Console.WriteLine("Minimali reiksme yra: " + min);
            Console.WriteLine("Maksimali reiksme yra: " + max);
            Console.WriteLine("Minimali reiksme yra: " + masyvas.Min());
            Console.WriteLine("Maksimali reiksme yra: " + masyvas.Max());
        }
    }
}