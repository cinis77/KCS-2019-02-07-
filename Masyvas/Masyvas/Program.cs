using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Masyvas
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            int[] M = { 1, 5, 10, 8, 6, 20, 200, 5, 8, 45, 9, 80, 23 };
            Console.WriteLine("Masyvo ilgis: " + M.Length);
            Console.WriteLine("Pirmas elementas masyve: " + M[0]);
            Console.WriteLine("Paskutinis elementas masyve: " + M[M.Length - 1]);
        }
    }
}