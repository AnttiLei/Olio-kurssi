using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labra4Tehtä5
{
    class Program
    {
        static void Main(string[] args)
        {
            Vehicles bike1 = new Bikes("Jopo ", ": Street :",2016, ": Blue ", " False", "0");
            Console.WriteLine("Bike info\n " + bike1);

            Vehicles bike2 = new Bikes("Tunturi ", ": StreetPower :", 2010, ": Black ", ": True", ": Shimano");
            Console.WriteLine("Bike2 info\n " + bike2);

            Vehicles boat1 = new Boats("Suvi ", ": S900 :", 1990, ": White :", " Rowboat :", 3);
            Console.WriteLine("Boat info\n " + boat1);

            Vehicles boat2 = new Boats("Yamaha ", ": 1000 :", 2010, " Yellow ", " Motorboat :", 5);
            Console.WriteLine("Boat2 info\n " + boat2);

           
        }
    }
}

