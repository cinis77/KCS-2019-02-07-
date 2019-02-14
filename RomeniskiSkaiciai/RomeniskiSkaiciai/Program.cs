using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RomeniskiSkaiciai
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine("Iveskite skaiciu");
            int skaicius = Convert.ToInt32(Console.ReadLine());
            if (skaicius == 1000)
            {
                Console.WriteLine("M");
            }
            else
            {
                int simtai = skaicius / 100;
                int desimtys = (skaicius % 100) / 10;
                int vientetai = skaicius % 10;
                if (simtai != 0)
                {
                    string kintamasis = VienetaiIRomeniskus(simtai, "C", "D", "CM");
                    Console.Write(kintamasis);
                }
                if (desimtys != 0)
                {
                    string kintamasis = VienetaiIRomeniskus(desimtys, "X", "L", "XC");
                    Console.Write(kintamasis);
                }
                if (vientetai != 0)
                {
                    string kintamasis = VienetaiIRomeniskus(vientetai, "I", "V", "IX");
                    Console.WriteLine(kintamasis);
                }
            }
        }

        public static string VienetaiIRomeniskus(int sk, string vienas, string penkti, string devyni)
        {
            if (sk == 4)
            {
                return (vienas + penkti);
            }
            else if (sk == 9)
            {
                return devyni;
            }
            else
            {
                int penki = sk / 5;
                int pagaliukuKiekis = sk % 5;
                string atsakymas = "";
                if (penki != 0)
                {
                    atsakymas += penkti;
                }
                for (int i = 0; i < pagaliukuKiekis; i++)
                {
                    atsakymas += vienas;
                }
                return atsakymas;
            }
        }
    }
}