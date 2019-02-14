using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SkaiciavimaiSuMEtodais
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine("Iveskite skaiciu");
            int sk1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Iveskite skaiciu");
            int sk2 = Convert.ToInt32(Console.ReadLine());
            var suma = Suma(sk1, sk2);
            Console.WriteLine("Suskaiciuota suma: " + suma);
            Console.WriteLine("Skirtumas: " + Skirtumas(sk1, sk2));
            int sandaiga = Sandauga(b: sk2, a: sk1);
            Console.WriteLine("Sandauga: " + sandaiga);
            var dalyba = Dalyba(sk1, sk2);
            Console.WriteLine("Dalyba: " + dalyba);
        }

        public static int Suma(int a, int b)
        {
            return (a + b);
        }

        public static int Skirtumas(int a, int b)
        {
            int skirtumas = a - b;
            return skirtumas;
        }

        public static int Sandauga(int a, int b)
        {
            return (a * b);
        }

        public static double Dalyba(int a, int b)
        {
            double dalyba = (double)a / b;
            return dalyba;
        }
    }
}