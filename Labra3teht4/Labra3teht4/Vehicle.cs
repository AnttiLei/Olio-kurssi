using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labra3teht4
{
    public class Vehicle
    {
        public string Name { get; set; }
        public int Speed { get; set; }
        public int Tyres { get; set; }

        public void PrintData()
        {
            Console.WriteLine("Ajoneuvon nimi on {0}", Name);
            Console.WriteLine("Ajoneuvon nopeus on {0}", Speed);
            Console.WriteLine("Ajoneuvon renkaiden määrä {0}", Tyres);
            
        }
        public override string ToString()
        {
            string tiedot = Name + ", nopeus: " + Speed + " km/h, " + Tyres + " kpl renkaita";
            Console.WriteLine(tiedot);
            return tiedot;
        }
    }
}
