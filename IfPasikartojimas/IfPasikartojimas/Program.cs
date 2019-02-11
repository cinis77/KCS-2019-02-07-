using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IfPasikartojimas
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine("Iveskite skaiciu");
            var sk = Convert.ToInt32(Console.ReadLine());
            int tukst = sk / 1000;
            int simt = (sk / 100) % 10;
            int desimt = (sk / 10) % 10;
            int vnt = sk % 10;

            if (sk > 9999)
            {
                Console.WriteLine("Ivestas netinkamas skaicius");
            }
            else if (sk > 999)
            {
                int naujasSK = vnt * 1000 + desimt * 100 + simt * 10 + tukst;
                Console.WriteLine("Naujas skaicius yra " + naujasSK);
            }
            else if (sk > 99)
            {
                int naujasSK = vnt * 100 + desimt * 10 + simt;
                Console.WriteLine("Naujas skaicius yra " + naujasSK);
            }
            else if (sk > 9)
            {
                int naujasSK = vnt * 10 + desimt;
                Console.WriteLine("Naujas skaicius yra " + naujasSK);
            }
            else
            {
                Console.WriteLine("Naujas skaicius yra " + sk);
            }
        }
    }
}