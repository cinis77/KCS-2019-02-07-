using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methodai
{
    internal class Program
    {
        public static void Tekstas(string IsvedamasTekstas)
        {
            Console.WriteLine(IsvedamasTekstas);
        }

        public static void Kazkas()
        {
        }

        public int a;

        private static void Main(string[] args)
        {
            //IsvedimasIKonsole("Isvedamas Tesktas");
            string tekstasISvesti = "KitasTekstas";
            //IsvedimasIKonsole(tekstasISvesti);
            Program p = new Program();
            p.IsvedimasIKonsole(tekstasISvesti);
            Console.WriteLine("Iveskite teksta");
            string tekstas = Console.ReadLine();
            Console.WriteLine("Jusu ivestas tekstas ");
            BetkokioTekstoIsvedimas(tekstas);
        }

        public static void BetkokioTekstoIsvedimas(string tekstas)
        {
            Console.WriteLine(tekstas);
        }

        public void IsvedimasIKonsole(string tekstas)
        {
            Console.WriteLine(tekstas);
        }
    }
}