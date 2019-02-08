using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElseIF
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine("Iveskite amziu");
            int amzius = Convert.ToInt32(Console.ReadLine());
            if (amzius > 14)
            {
                Console.WriteLine("Jusu amzius yra didesnis uz skaiciu 14");
            }
            else if (amzius > 6)
            {
                Console.WriteLine("Jusu amzius yra didesnis uz 6");
            }
            else
            {
                Console.WriteLine("Jusu amzius nera didesnis nei uz 14 nei uz 6");
            }
        }
    }
}