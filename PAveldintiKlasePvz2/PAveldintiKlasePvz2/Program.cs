using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PAveldintiKlasePvz2
{
    internal class Pirma
    {
        public Pirma(int vienas)
        {
        }

        public virtual void MetodasVirtualus()
        {
            Console.WriteLine("Klase pirma issikviecia metoda");
        }
    }

    internal class Antra : Pirma
    {
        public Antra(int du, int vienas) : base(vienas)
        {
        }

        public override void MetodasVirtualus()
        {
            base.MetodasVirtualus();
            Console.WriteLine("Klase antra issikviecia metoda");
        }
    }

    internal class Trys : Antra
    {
        public Trys(int trys, int du, int vienas) : base(vienas, du)
        {
        }
    }

    internal class Program
    {
        private static void Main(string[] args)
        {
            Antra antra = new Antra(1, 2);
            antra.MetodasVirtualus();
        }
    }
}