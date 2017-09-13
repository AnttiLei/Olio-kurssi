using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tehätävä5
{
    class Program
    {
        
        static void Main(string[] args)
        {
                         
            int vastaus;                    
            Console.WriteLine("Anna sekunnit");
            vastaus = int.Parse(Console.ReadLine());
            int tun = vastaus / 3600;
            int min = (vastaus % 3600) / 60;
            int sek = (vastaus % 3600) % 60;
            Console.WriteLine("Antamasi sekunttiaika voidaan ilmaista muodossa {0} tuntia {1} minuuttia ja {2} sekunttia", tun, min, sek); 

        }
    }
}
