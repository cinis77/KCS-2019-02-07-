using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aparatas
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine("Pasirinkite viena is galimu variantu: ");
            Console.WriteLine("1-limonadas\n2-arbata\n3-kakava\n4-kava\n5-nieko");
            Console.WriteLine("Jusu pasirinkimas");
            string pasirinkinimas = Console.ReadLine();
            switch (pasirinkinimas)
            {
                case "1"://1 => int
                    Console.WriteLine("Jus pasirinkote limonada");
                    break;

                case "2":
                    Console.WriteLine("Jus pasirinkote arbata");
                    break;

                case "3":
                    Console.WriteLine("Jus pasirinkote kakava");
                    break;

                case "4":
                    Console.WriteLine("Jus pasirinkote kava");
                    break;

                case "5":
                    Console.WriteLine("Jus pasirinkote nieko");
                    break;

                default:
                    Console.WriteLine("Blogas pasirinkimas");
                    break;
            }
        }
    }
}