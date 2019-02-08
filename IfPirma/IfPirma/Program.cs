using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IfPirma
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine("Iveskite skaiciu");
            int sk1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Iveskite skaiciu");
            int sk2 = Convert.ToInt32(Console.ReadLine());
            if (sk1 > sk2)
            { //jei salyga tenkina vykdo koda
                Console.WriteLine("Pirmas skaicius {0} yra didesnis uz "
                    + "antra skaiciu {1}", sk1, sk2);
            }
            if (sk1 < sk2)
            {
                Console.WriteLine("Pirmas skaicius {0} yra mazesnis uz "
                    + "antra skaiciu {1}", sk1, sk2);
            }
            if (sk1 == sk2)
            {
                Console.WriteLine("Äbu skaiciai yra lygus");
            }
        }
    }
}