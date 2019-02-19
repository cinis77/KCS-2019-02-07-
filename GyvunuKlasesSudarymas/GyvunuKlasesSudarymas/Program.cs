using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GyvunuKlasesSudarymas
{
    internal class Gyvunas
    {
        private int _svoris;

        public string Vardas { get; private set; }

        public int Svoris
        {
            get
            {
                return _svoris;
            }
            set
            {
                if (value != _svoris)
                {
                    _svoris = value;
                    Bega();
                }
            }
        }

        public readonly List<int> Matavimai;

        public int Amzius { get; } //Reiksme pasiekiama is visur, pakeisti reiksme negalima
        private string Rusis;
        public string Kilme { get; private set; }

        public Gyvunas(int svoris, int amzius, string rusis, string kilme)
        {
            Svoris = svoris;
            Amzius = amzius;
            Rusis = rusis;
            Kilme = kilme;
            Matavimai = new List<int>();
        }

        public Gyvunas(int svoris, int amzius)
        {
        }

        public Gyvunas()
        {
        }

        public void PakeistiRusis(string rusys)
        {
            Rusis = rusys;
        }

        public string GrazinaRusis()
        {
            return Rusis;
        }

        public void Bega()
        {
            Console.WriteLine("Bega " + Rusis);
            Kilme = "Kilminga";
        }

        public void Skrenda()
        {
            Console.WriteLine("Skrenda " + Rusis);
            Svoris = 20;
        }

        public int GimimoMetuSkaiciavimas()
        {
            return DateTime.Today.Year - Amzius;
        }
    }

    internal class Program
    {
        private static void Main(string[] args)
        {
            Gyvunas suo = new Gyvunas(10, 8, "Suo", "Didele");
            Gyvunas arklys = new Gyvunas(90, 5);
            Gyvunas meskenas = new Gyvunas();
            Gyvunas kate = new Gyvunas(4, 6, "Kate", "Nezinau");
            suo.PakeistiRusis("Karve");
            suo.Svoris = 500;
            suo.Bega();
            kate.Skrenda();
            kate.Matavimai.Add(10);
            kate.Matavimai.Add(1);
            kate.Matavimai.Add(8);
            kate.Matavimai.Add(2);
            kate.Matavimai.Remove(2);
            kate.Matavimai.RemoveAt(1);
            kate.Matavimai.RemoveAll(x => x != 2);
            kate.Matavimai.Clear();
            List<int> kazkas = new List<int>();

            Console.WriteLine(suo.GimimoMetuSkaiciavimas());
            Console.WriteLine((kate.GimimoMetuSkaiciavimas()));
        }
    }
}