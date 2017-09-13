using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tehtävä4
{
    class Teht4
    {
        static void Tehtävä4(string[] args)
        {
            int age;
            Console.WriteLine("Kerro ikäsi: ");
            age = int.Parse(Console.ReadLine());

            if (age < 18)
            {
                Console.WriteLine("Olet alaikäinen");

            }
            else if (age < 66)
            {
                Console.WriteLine("Olet aikuinen");
            }
            else
            {
                Console.WriteLine("Olet Seniori");
            }
        }
    }
}
