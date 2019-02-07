using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AritmetiniaiVeiksmai
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            int a = Convert.ToInt32(Console.ReadLine());
            int b = Convert.ToInt32(Console.ReadLine());
            int sum = a + b;
            int skirtumas = a - b;
            int sandauga = a * b;
            double dalmuo = (double)a / b;
            Console.WriteLine("{0} + {1} = {2}", a, b, sum);
            Console.WriteLine("{0} - {1} = {2}", a, b, skirtumas);
            Console.WriteLine("{0} * {1} = {2}", a, b, sandauga.ToString("F2"));
            Console.WriteLine("{0} / {1} = {2:0.00}", a, b, dalmuo);
        }
    }
}