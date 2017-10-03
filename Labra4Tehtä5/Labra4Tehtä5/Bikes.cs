using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labra4Tehtä5
{
    class Bikes : Vehicles
    {
        public string GearWheels { get; set; }
        public string GearName { get; set; }

        public Bikes(string name, string model, int year, string color, string gearWheels, string gearName) : base(name, model, year, color)
        {
            GearWheels = gearWheels;
            GearName = gearName;

        }
        public override string ToString()
        {

            return "Name: " + Name + " Model " + Model + " Model year " + Year + " Color: " + Color + " GearWheels: " + GearWheels + " GearName " + GearName;
        }
    }
}