using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetodasOut
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            int sk1 = 10;
            int sk2 = 15;
            int sum = 0;
            double vid = 0;
            Console.WriteLine("Suma = {0}, vidurkus = {1}", sum, vid);
            Skaiciavimai(sk1, sk2, out sum, out vid);
            Console.WriteLine("Suma = {0}, vidurkus = {1}", sum, vid);
        }

        public static void Skaiciavimai(int a, int b, out int suma, out double vidurkis)
        {
            suma = a + b;
            vidurkis = (double)(a + b) / 2;
        }
    }
}