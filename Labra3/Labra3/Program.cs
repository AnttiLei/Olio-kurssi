using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labra3
{
    class Program
    {
        static void Main(string[] args)
        {
            TestaaKiuas();
        }
        //Kiuas-luokan testaus
        static void TestaaKiuas()
        {
            //luodaan kiuas olio
            Kiuas kiuas = new Kiuas();
            kiuas.PowerOn = true;
            kiuas.Temperature = 80;
            kiuas.Moisture = 60;

            //tulostetaan juuri luotu kiuas olio
            Console.WriteLine("Kiuas on päällä {0}", kiuas.PowerOn);
            Console.WriteLine("Kiukaan lämpötila {0}", kiuas.Temperature);
            Console.WriteLine("Kiukaan kosteus {0}", kiuas.Moisture);
          
        }
    }
}
