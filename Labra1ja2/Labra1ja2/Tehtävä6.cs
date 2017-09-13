using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tehtävä6
{
    class Teht6
    {
        static void Tehtävä6(string[] args)
        {
            //Auton kulutus on 7.02 litraa 100 kilometrin matkalla ja bensan hinta on 1.595 Euroa.
            //Tee ohjelma, joka tulostaa ajetulla matkalla (kysytään käyttäjältä) kuluvan bensan määrän sekä bensaan menevän rahan määrän.

            int kilsat;
            double litrat = 7.02;
            double bensa = 1.595;
            Console.WriteLine("Anna matka");
            kilsat = int.Parse(Console.ReadLine());
            double kulutus = kilsat / (100 / litrat);
            double hinta = kulutus * bensa;
            Console.WriteLine("Bensaa kuluu {0} litraa, kustannus {1} euroa.", kulutus, hinta);
            
        }
    }
}
