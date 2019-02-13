using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JaunasisMatematikas
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            double turtuolisSumokejo = 0;
            double matematikasSumokejo = 0;
            for (int i = 1; i <= 31; i++)
            {
                matematikasSumokejo += 1000000;
                turtuolisSumokejo += Math.Pow(2, i) / 100;
            }
            Console.WriteLine("Matematikas sumokejo: " + matematikasSumokejo);
            Console.WriteLine("Turtuolis sumokejo: " + turtuolisSumokejo);
            Console.WriteLine("Turtuolis sumokejo: " + (turtuolisSumokejo - matematikasSumokejo));
        }
    }
}