using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labra4Tehtä5
{
    class Boats : Vehicles
    {
        public string Type { get; set; }
        public int Seats { get; set; }

        public Boats(string name, string model, int year, string color, string type, int seats) : base(name, model, year, color)
        {
            Type = type;
            Seats = seats;
            
        }
        public override string ToString()
        {
            
            return "Name: " + Name + " Model " + Model + " Model year " + Year + " Color: " + Color + " Type: " + Type + " Seats " + Seats;
        }
    }
}


