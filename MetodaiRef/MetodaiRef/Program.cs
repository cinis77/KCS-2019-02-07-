using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetodaiRef
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            int sk1 = 10;
            int sk2 = 5;
            Console.WriteLine("Skacius1 = {0} Skaicius2 = {1}", sk1, sk2);
            MEtodasSuRef(sk1, ref sk2);
            Console.WriteLine("Skacius1 = {0} Skaicius2 = {1}", sk1, sk2);
        }

        public static void MEtodasSuRef(int a, ref int b)
        {
            b = a;
        }
    }
}