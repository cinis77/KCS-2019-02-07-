using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laiptai
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine("Iveskite skaiciu");
            int skaicius = Convert.ToInt32(Console.ReadLine());
            for (int eilutes = 0; eilutes < skaicius; eilutes++)
            {
                for (int tarpeliai = skaicius - (eilutes + 1); tarpeliai > 0; tarpeliai--)
                {
                    Console.Write(" ");
                }
                for (int laiptelis = 0; laiptelis < eilutes + 1; laiptelis++)
                {
                    Console.Write("#");
                }
                Console.WriteLine();
            }
        }
    }
}