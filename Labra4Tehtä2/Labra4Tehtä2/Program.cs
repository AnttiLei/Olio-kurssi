using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labra4Tehtä2
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Elevator elevator = new Elevator();
            bool result;
            
                Console.WriteLine("Hissi on nyt kerroksessa : " + elevator.Floor);
                Console.WriteLine("Anna kerroksen numero (1-5) > ");

                String line = Console.ReadLine();
                int floor;
                result = Int32.TryParse(line, out floor);

                if (result)
                {
                    elevator.Floor = floor;
                }

            Console.WriteLine("Hissi on nyt kerroksessa " + floor);








        }
    }
}
