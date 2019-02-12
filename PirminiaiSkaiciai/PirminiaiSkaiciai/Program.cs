using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PirminiaiSkaiciai
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            int suma = 0;
            for (int i = 2; i < 1000; i++)
            {
                bool Pirminis = true;
                for (int j = 2; j < i; j++)
                {
                    if ((i % j) == 0)
                    {
                        Pirminis = false;
                        break;
                    }
                }
                if (Pirminis == true) // If(Pirminis == true)
                {
                    Console.WriteLine(i);
                    suma += i;
                }
            }
            Console.WriteLine(suma);
        }
    }
}