using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiegoSkaiciavimas
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            //59
            for (int a = 0; a <= 18; a++)
            {
                double t = 8 + (double)(18 - a) / 2; // => valandos pramiegotos per diena
                t *= 365;
                Console.WriteLine(t);
            }
            //60
            for (int i = -10; i <= 10; i++)
            {
                double ats = Math.Pow(i, 2) * 7 + 5 * i - 3;
                Console.WriteLine(ats);
            }
            //61
            for (int i = 0; i <= DateTime.Today.Year; i++)
            {
                if ((i % 4) == 0)
                {
                    if ((i % 100) == 0)
                    {
                        if ((i % 400) == 0)
                        {
                            Console.WriteLine(i);
                        }
                    }
                    else
                    {
                        Console.WriteLine(i);
                    }
                }
            }
        }
    }
}