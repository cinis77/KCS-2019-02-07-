using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LyginioPatikrinimas
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine("Iveskite skaiciu");
            int sk = Convert.ToInt32(Console.ReadLine());
            int liekana = sk % 2;
            if (liekana == 0)
            {
                Console.WriteLine("Skaicius yra lyginis");
            }
        }
    }
}