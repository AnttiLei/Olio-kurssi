using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labra3teht2
{
    class Program
    {
        static void Main(string[] args)
        {
            TestaaPesukone();
        }
        static void TestaaPesukone()
        {
            //luodaan pesukone-olio ja annetaan sille tiedot
            Pesukone pesukone = new Pesukone();
            pesukone.PowerOn = true;
            pesukone.DoorClosed = true;
            pesukone.WaterOn = true;
            
            //tulostetaan juuri luotu olio
            Console.WriteLine("Pesukoneen virta on päällä {0}", pesukone.PowerOn);
            Console.WriteLine("Pesukoneen luukku on kiinni {0}", pesukone.DoorClosed);
            Console.WriteLine("Pesukone saa vettä {0}", pesukone.WaterOn);
            
        }
    }
}
