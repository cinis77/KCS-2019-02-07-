using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MasyvasTemperaturos
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            double[] temperaturos =
                {
                1, 2.3, 0.5, -6, -3, 2, 9, 3, -1, 3.5, 6.5, 3.4, 6.8, -1.2, 3.1
            };
            Console.WriteLine("Didziausia temperatura yra: " + temperaturos.Max());
            Console.WriteLine("Zemiausia temperatura yra: " + temperaturos.Min());
            Console.WriteLine("Temperaturu vidurkis yra: {0:0.00}", temperaturos.Average());
            double suma = 0;
            foreach (var temperatura in temperaturos)
            {
                if (temperatura < temperaturos.Average())
                {
                    suma += temperatura;
                }
            }
            Console.WriteLine("Suma mazesniu uz vidurki yra: " + suma);
        }
    }
}