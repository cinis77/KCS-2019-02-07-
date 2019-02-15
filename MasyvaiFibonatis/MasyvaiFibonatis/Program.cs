using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MasyvaiFibonatis
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            int[] masyvas = new int[10];
            masyvas[0] = 1;
            masyvas[1] = 1;
            for (int i = 2; i < masyvas.Length; i++)
            {
                masyvas[i] = masyvas[i - 1] + masyvas[i - 2];
            }
            foreach (var item in masyvas)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();
            Random rng = new Random();
            Console.WriteLine(rng.Next());
            Console.WriteLine(rng.Next(-10, 10));
        }
    }
}