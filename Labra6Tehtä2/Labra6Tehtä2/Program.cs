using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labra6Tehtä2
{
    class Program
    {
        static void Main(string[] args)
        {

            Jaakaappi oma = new Jaakaappi("Samsung ", "RB28h ", 24);
            Console.WriteLine("Onneksi olkoon uudesta jääkaapista {0}", oma);
        }

        

        class Jaakaappi
        {
            public string Valmistaja { get; set; }
            public string Malli { get; set; }
            public int Kaljat { get; set; }

            public Jaakaappi(string valmistaja, string malli, int kaljat)
            {
                Valmistaja = valmistaja;
                Malli = malli;
                Kaljat = kaljat;
            }

            public override string ToString()
            {
                return "Valmistaja: " + Valmistaja + "Malli: " + Malli + "Sisällä: " + Kaljat + " olutta.";
            }






        }
            
    }
}


