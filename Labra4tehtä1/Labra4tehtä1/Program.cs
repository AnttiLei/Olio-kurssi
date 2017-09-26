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
            Console.WriteLine("Anna numerosarja > ");
            string line = Console.ReadLine();
            // try to read number from the given line
            double number;
            bool result = double.TryParse(line, out number);
            //number (integer) was given correctly, use it..
            if (result)
            {
                Console.WriteLine("Numero oli " + number);
            }
            else
            {
                Console.WriteLine("Syöte {0} ei ole luku",line);
                
            }
            Console.WriteLine("Anna toinen numerosarja > ");
            string line2 = Console.ReadLine();
            DateTime date;

            if (DateTime.TryParse(line2, out date))
            {
                Console.WriteLine("Syöte on " + line2);
            }
            else
            {
                Console.WriteLine("Syöte {0} ei ollut päivämäärä.", line2);
            }
           
        }
    }
}
