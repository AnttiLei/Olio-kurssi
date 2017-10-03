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
            Staff person = new Staff("antti", "leinonen", "Duunari", 1244);
           Console.WriteLine("Employee:\n " + person);
            Staff boss = new Boss("Lantti", "Keinonen", "Pomo", 4421, "Ferrari", 2500);
            Console.WriteLine("Boss:\n " + boss);
            Staff person2 = new Staff("Matti", "Menninkäinen", "Työmies", 1444);
            Console.WriteLine("Employee:\n " + person2);
        }
    }
}
