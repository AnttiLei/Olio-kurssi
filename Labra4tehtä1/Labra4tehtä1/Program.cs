using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labra4tehtä1
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Give a number > ");
            string line = Console.ReadLine();
            // try to read number from the given line
            float number;
            bool result = float.TryParse(line, out number);
            // number (integer) was given correctly, use it..
            if (result)
            {
                Console.WriteLine("Number was " + number);
            }
            else
            {
                Console.WriteLine("Syöte {0} ei ole luku", Testi.OnkoLuku);
            }
        }
    }
}
