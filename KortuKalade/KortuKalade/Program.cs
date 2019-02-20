using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KortuKalade
{
    internal class Korta
    {
        public string Simbolis { get; set; }
        public string Skaicius { get; set; }
        public string Spalva { get; set; }

        public Korta(string simbolis, string skaicius)
        {
            Simbolis = simbolis;
            Skaicius = skaicius;
            PakeistiISkaiciuSimboli();
        }

        private void PakeistiISkaiciuSimboli()
        {
            switch (Skaicius)
            {
                case "1":
                    Skaicius = "A";
                    break;

                case "11":
                    Skaicius = "J";
                    break;

                case "12":
                    Skaicius = "Q";
                    break;

                case "13":
                    Skaicius = "K";
                    break;
            }
        }
    }

    internal class Program
    {
        private static void Main(string[] args)
        {
            Random rng = new Random();
            string[] Simboliai = { "Sirdys", "Pikai", "Kryziai", "Bugnai" };
            List<Korta> kalade = new List<Korta>();
            int i = 0;
            while (i < 52)
            {
                Korta korta = new Korta(Simboliai[rng.Next(0, 4)], rng.Next(1, 14).ToString());
                bool pozymis = true;
                foreach (var item in kalade)
                {
                    if (item.Simbolis == korta.Simbolis && item.Skaicius == korta.Skaicius)
                    {
                        pozymis = false;
                    }
                }
                if (pozymis)
                {
                    kalade.Add(korta);
                    i++;
                }
            }
            foreach (var item in kalade)
            {
                Console.WriteLine(item.Simbolis + " " + item.Skaicius);
            }
        }
    }
}