﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SwitchPirma
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
            switch (sk1)
            {
                case 1:
                    Console.WriteLine("Suma :" + (sk1 + sk2 + sk3));
                    break;

                case 2:
                    Console.WriteLine("Skirtumas :" + (sk1 - sk2));
                    break;

                case 3:
                    Console.WriteLine("Sandauga :" + (sk2 * sk3));
                    break;

                default:
                    break;
            }
        }
    }
}