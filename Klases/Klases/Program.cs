using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Klases
{
    internal struct Auto
    {
        public string Marke;
        public string Modelis;
        public int GamybosMetai;
    }

    internal class Automobilis
    {
        public string Marke;
        public string Modelis;
        public int GamybosMetai;
        public int Rida;

        public double KilometraiPerMetus()
        {
            int automobilioAmzius = DateTime.Today.Year - GamybosMetai;
            return (double)Rida / automobilioAmzius;
        }

        public Automobilis(string marke, string modelis, int gamybosMetai, int rida)
        {
            Marke = marke;
            Modelis = modelis;
            GamybosMetai = gamybosMetai;
            Rida = rida;
        }
    }

    internal class Program
    {
        private static void Main(string[] args)
        {
            Automobilis auto1 = new Automobilis(marke: "Audi", modelis: "A8", gamybosMetai: 2015, rida: 15000);
            Console.WriteLine(auto1.KilometraiPerMetus());
            Console.WriteLine(auto1.Marke);
        }
    }
}