using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labra6Tehtäv1
{
    class Program
    {
        static void Main(string[] args)
        {
            Kulkuneuvo a = new Kulkuneuvo("Porsche ", "911 ");
            Rengas a1 = new Rengas("Nokia ", "Hakkapeliitta ", "205R16");
            Console.WriteLine("Uusi auto luotu: {0} ja siihen uudet renkaat {1}", a, a1);

            Kulkuneuvo b = new Kulkuneuvo("Ducati ", "Diavel ");
            Rengas b1 = new Rengas("MIC ", "Pilot ", "160R17");
            Console.WriteLine("Uusi moottoripyörä luotu: {0} ja siihen uudet renkaat {1}", b, b1);

        }



        class Rengas 
        { 
        
            public string Merkki { get; set; }
            public string Tyyppi { get; set; }
            public string Rengaskoko { get; set; }

            public Rengas(string merkki, string tyyppi, string rengaskoko)
            {
                Merkki = merkki;
                Tyyppi = tyyppi;
                Rengaskoko = rengaskoko;
            }

            public override string ToString()
            {
                return "Merkki: " + Merkki + "Tyyppi: " + Tyyppi + "Rengaskoko: " + Rengaskoko;
            }



        }

        class Kulkuneuvo
        {
            public string Nimi { get; set; }
            public string Malli { get; set; }

            public Kulkuneuvo(string nimi, string malli)
            {
                Nimi = nimi;
                Malli = malli;
            }

            public override string ToString()
            {
                return "Nimi: " + Nimi + "Malli: " + Malli;
            }
        }
    }




}
    
