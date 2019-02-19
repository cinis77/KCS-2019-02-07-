using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstrakciosKlases
{
    internal abstract class Figura
    {
        public int Atstumas;

        public void Metodas()
        {
        }

        public abstract void PlotoSkaiciavimas();
    }

    internal class Trikampis : Figura
    {
        public override void PlotoSkaiciavimas()
        {
            Console.WriteLine("Trikampio plotas skaiciuojamas 1/2 * a * b");
        }
    }

    internal class Apskritimas : Figura
    {
        public override void PlotoSkaiciavimas()
        {
            Console.WriteLine("Apskritimo plotas skaiciuojamas pi * r *r");
        }
    }

    internal class Program
    {
        private static void Main(string[] args)
        {
        }
    }
}