using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForAntra
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            int sandauga = 1;
            for (int i = 1; i < 100; i++)
            {
                if ((i % 7) == 0)
                {
                    sandauga *= i;
                }
            }
            Console.WriteLine(sandauga);
        }
    }
}