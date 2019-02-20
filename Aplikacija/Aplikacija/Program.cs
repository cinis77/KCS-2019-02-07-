using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aplikacija
{
    internal class Taskas
    {
        public int X { get; }
        public int Y { get; }

        public Taskas(int x, int y)
        {
            X = x;
            Y = y;
        }

        public double DistanceBetweenPoints(Taskas taskas)
        {
            var distance = Math.Sqrt(Math.Pow(X - taskas.X, 2) + Math.Pow(Y - taskas.Y, 2));
            return distance;
        }
    }

    internal class Program
    {
        private static void Main(string[] args)
        {
            Random rng = new Random();
            List<Taskas> taskai = new List<Taskas>();
            for (int i = 0; i < rng.Next(10, 50000); i++)
            {
                Taskas temp = new Taskas(rng.Next(-100, 100), rng.Next(-100, 100));
                taskai.Add(temp);
            }

            Taskas centroTaska = new Taskas(5, 6);
            double R = 25;
            foreach (var item in taskai)
            {
                if (R >= item.DistanceBetweenPoints(centroTaska))
                {
                    Console.WriteLine("x: {0}, y: {1}", item.X, item.Y);
                }
            }
        }
    }
}