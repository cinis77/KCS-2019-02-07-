using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Daugyba
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine("Iveskite skaiciu");
            int sk = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Iveskite skaiciu");
            int sk2 = Convert.ToInt32(Console.ReadLine());
            int sandauga = 0;
            for (int i = 0; i < sk2; i++)
            {
                sandauga += sk;// sandauga = sandauga + sk
            }
            Console.WriteLine("Sandauga: " + sandauga);
        }
    }
}