using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KlasaX
{
    static class KlasaX
    {
        static private int broj;

        static public int Broj { get => broj; set => broj = value; }
    }
        internal class Program
    {
        static void Main(string[] args)
        {
            KlasaX.Broj = 10;
            Console.WriteLine("Vrijednost varijable je : "+Convert.ToString(KlasaX.Broj)+".");

            Console.ReadKey();
        }
    }
}
