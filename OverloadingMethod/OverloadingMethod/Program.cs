using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OverloadingMethod
{
    internal class Sudetis
    {
        public Sudetis()
        {
        }

        public int Add(int sk1, int sk2)
        {
            return sk1 + sk2;
        }

        public int Add(int sk1, int sk2, int sk3)
        {
            return sk1 + sk2 + sk3;
        }
    }

    internal class Program
    {
        private static void Main(string[] args)
        {
            Sudetis sudetis = new Sudetis();
            var atsakymas = sudetis.Add(1, 2);
            var atsakymas1 = sudetis.Add(1, 2, 3);
        }
    }
}