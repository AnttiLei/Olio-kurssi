using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labra3teht4
{
    public class Program
    {
        static void Main(string[] args)
        {
            //Luodaan kulkuneuvo-olio
            Vehicle vehicle = new Vehicle();
            vehicle.Name = "Auto";
            vehicle.Speed = 180;
            vehicle.Tyres = 4;

            //Luodaan toinen kulkuneuvo-olio
            Vehicle vehicle1 = new Vehicle();
            vehicle1.Name = "Moottoripyörä";
            vehicle1.Speed = 250;
            vehicle1.Tyres = 2;

            //Tulostetaan ekana luodon olion tiedot
            vehicle.PrintData();
            vehicle.ToString();

            Console.WriteLine();

            //Tulostetaan seuraavana luodon olion tiedot
            vehicle1.PrintData();
            vehicle1.ToString();
        }
    }
}
