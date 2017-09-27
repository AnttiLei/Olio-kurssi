using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labra4Tehtä4
{
    class Program
    {
        static void Main(string[] args)
        {
            Staff person = new Staff("antti", "leinonen", "työntekijä", 1244);
           Console.WriteLine("Eka tekijä" + person);
        }
    }
}
