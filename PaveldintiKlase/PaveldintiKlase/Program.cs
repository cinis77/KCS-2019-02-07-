using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PaveldintiKlase
{
    internal class TransportoPriemone
    {
        public int Svoris;
        public int KeleiviuSkaicius;
        public string Spalva;
        protected string Gamintojas;

        public TransportoPriemone(string Gamintojas, int Svoris, int keleiviuSk)
        {
        }
    }

    internal class Automobilis : TransportoPriemone
    {
        public string Marke;
        public string Tipas;
        public int Rida;

        public Automobilis(string gamintojas, int svoris, int keleiviuSkaicius, string Marke)
            : base(gamintojas, svoris, keleiviuSkaicius)
        {
        }
    }

    internal class Program
    {
        private static void Main(string[] args)
        {
            Automobilis auto = new Automobilis("Audi", 2000, 5, "");
        }
    }
}