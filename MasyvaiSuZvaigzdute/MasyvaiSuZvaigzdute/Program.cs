using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MasyvaiSuZvaigzdute
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine("Iveskite skaiciu");
            int skaicius = Convert.ToInt32(Console.ReadLine());
            int kiekis = 0;
            int tikrinimas = 1;
            while (tikrinimas <= skaicius)
            {
                tikrinimas *= 2;
                kiekis++;
            }
            int[] masyvas = new int[kiekis];
            masyvas[0] = 1;
            for (int i = 1; i < masyvas.Length; i++)
            {
                masyvas[i] = masyvas[i - 1] * 2;
            }
            foreach (var item in masyvas)
            {
                Console.WriteLine(item);
            }
        }
    }
}