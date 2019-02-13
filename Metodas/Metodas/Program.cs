using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Metodas
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine("Iveskite tekstas");
            string tekstas = Console.ReadLine();
            T(tekstas);
        }

        public static void T(string tekstas)
        {
            Console.WriteLine(tekstas);
        }
    }
}