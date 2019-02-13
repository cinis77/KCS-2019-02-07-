using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KaraliausIzdas
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine("Iveskite koks karaliaus izdo dydis");
            int n = Convert.ToInt32(Console.ReadLine());
            int pirma = 1;
            int antra = 1;
            n -= pirma + antra;
            int naktuKiekis = 2;
            while (n > 0)
            {
                int naujosnaktiesmokejimas = pirma + antra;
                n -= naujosnaktiesmokejimas;
                naktuKiekis++;
                pirma = antra;
                antra = naujosnaktiesmokejimas;
                Console.WriteLine(naujosnaktiesmokejimas);
            }
            Console.WriteLine("Pinigai baigsis po: " + naktuKiekis);
        }
    }
}