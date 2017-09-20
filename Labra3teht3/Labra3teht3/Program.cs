using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labra3teht3
{
    class Program
    {
        static void Main()
        {
            TestaaTelevisio();
        }
        static void TestaaTelevisio()
        {
            Televisio tv = new Televisio();
            tv.PowerOn = true;
            tv.Volume = true;
            tv.Channel = 15;
            

            Console.WriteLine("Television virta on päällä {0}", tv.PowerOn);
            Console.WriteLine("Televisiossa äänet päällä {0}", tv.Volume);
            Console.WriteLine("Television kanava {0}", tv.Channel);
            
        }
    }
}
