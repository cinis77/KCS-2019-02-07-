using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VardaiSArasai
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Random rng = new Random();
            string[] vardai = { "Tomas", "Rokas", "Agne", "Joana", "Modesta", "Povilas" };
            List<string> varduSarasas = new List<string>();
            for (int i = 0; i < rng.Next(0, 50000); i++)
            {
                varduSarasas.Add(vardai[rng.Next(0, vardai.Length)]);
            }
            foreach (var item in varduSarasas)
            {
                Console.Write(item);
                Console.Write(", ");
            }
            Console.WriteLine();
        }
    }
}