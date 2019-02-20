using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SkaičiųSurikiavimas
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Random rng = new Random();
            List<int> skaiciai = new List<int>();
            for (int i = 0; i < rng.Next(0, 90000); i++)
            {
                skaiciai.Add(rng.Next(-500, 500));
            }
            List<int> SurikiuotiSkaiciai = new List<int>();
            while (skaiciai.Count != 0)
            {
                SurikiuotiSkaiciai.Add(skaiciai.Min());
                skaiciai.Remove(skaiciai.Min());
            }
            foreach (var item in SurikiuotiSkaiciai)
            {
                Console.WriteLine(item);
            }
        }
    }
}