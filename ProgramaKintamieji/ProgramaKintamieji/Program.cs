using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgramaKintamieji
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            string Vardas = "Dominykas";
            string Pavarde = "Rentelis";
            int Amzius = 26;
            double ugis = 1.8;
            double svoris = 96;
            string AukstojiMokykla = "Kauno Technologiju Universitetas";
            string AkademineGrupe = "RB @$ 1/4";
            char Kursas = '2';
            string Studiju_Programa = "Informacines technologijos";
            int atsiskaitytaKreditu = 180;

            Console.WriteLine("To Do programa");
            Console.WriteLine("1.Isvesti Suni");
            Console.WriteLine("2. Ismesti Siuksles");
            Console.WriteLine("3. Nusipirkti pieno");
            Console.WriteLine(4 + ".Pasimokinti");
            Console.WriteLine("{0}. {1}", 5, "Parasyti programa");
        }
    }
}