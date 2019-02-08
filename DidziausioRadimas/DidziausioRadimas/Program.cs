using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DidziausioRadimas
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine("Iveskite skaiciu");
            int sk1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Iveskite skaiciu");
            int sk2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Iveskite skaiciu");
            int sk3 = Convert.ToInt32(Console.ReadLine());
            if (sk1 > sk2 && sk1 > sk3)
            {
                Console.WriteLine("Skaicius {0} didziausias", sk1);
            }
            else if (sk2 > sk1 && sk2 > sk3)
            {
                Console.WriteLine("Skaicius {0} didziausias", sk2);
            }
            else if (sk3 > sk1 && sk3 > sk2)
            {
                Console.WriteLine("Skaicius {0} didziausias", sk3);
            }
        }
    }
}