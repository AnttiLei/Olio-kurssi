using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labra4Tehtä2
{
    class Elevator
    {
        
        private const int minFloor = 1;
        private const int maxFloor = 5;
        private int floor = 1;

        public int Floor
        {
            get
            {
                return floor;
            }
            set
            {
                if (value < minFloor || value > maxFloor)
                
                {
                    Console.WriteLine("Ei ole tuollaista kerrosta, mistä löysit tuon kerroksen nappulan?");
                }
                        
                else
                {
                    floor = value;
                }
            }
        }

    }
}
