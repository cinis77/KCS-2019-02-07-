using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VartotojaiPAvyzdys
{
    internal class Siunta
    {
        public string Dydis { get; set; }
        public string Adresas { get; set; }

        public Siunta()
        {
        }

        public double SiuntosSkaiciavimas()
        {
            switch (Dydis)
            {
                case "S":
                    return 2;

                case "M":
                    return 4;

                case "L":
                    return 6;

                case "XL":
                    return 8;

                default:
                    return 0;
            }
        }
    }

    internal class Vartotojas
    {
        public int ID;
        public string Vardas;
        public Siunta siunta;

        public Vartotojas()
        {
            siunta = new Siunta();
        }

        public virtual double MoketinaSuma(int suma)
        {
            return suma;
        }

        public double SiuntosKaina(string siuntosDydis)
        {
            Siunta siunta = new Siunta();
            siunta.Dydis = siuntosDydis;
            return siunta.SiuntosSkaiciavimas();
        }
    }

    internal class Vip : Vartotojas
    {
        public Vip()
        {
        }

        public override double MoketinaSuma(int suma)
        {
            double sumaMoketi = base.MoketinaSuma(suma);
            return (sumaMoketi * 0.7);
        }
    }

    internal class Silver : Vartotojas
    {
        public Silver()
        {
        }

        public override double MoketinaSuma(int suma)
        {
            double sumaMoketi = base.MoketinaSuma(suma);
            return sumaMoketi * 0.9;
        }
    }

    internal class Bazinis : Vartotojas
    {
    }

    internal class Program
    {
        private static void Main(string[] args)
        {
            Vip vip = new Vip();
            Silver silver = new Silver();
            Bazinis bazinis = new Bazinis();
            List<Vartotojas> vartotojas = new List<Vartotojas>();
            vartotojas.Add(vip);
            vartotojas.Add(silver);
            vartotojas.Add(bazinis);
            foreach (var item in vartotojas)
            {
                Console.WriteLine(item.MoketinaSuma(10));
                item.siunta.Dydis = "L";
                Console.WriteLine(item.siunta.SiuntosSkaiciavimas());
            }
        }
    }
}