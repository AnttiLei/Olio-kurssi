using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tehtävä3
{
    class Teht3
    {
        static void Main(string[] args)
        {
            int luku1;
            int luku2;
            int luku3;
            int summa;
            double keskiarvo;
            
                Console.WriteLine("Anna luku ");
                luku1 = int.Parse(Console.ReadLine());
                Console.WriteLine("Anna toinen luku ");
                luku2 = int.Parse(Console.ReadLine());
                Console.WriteLine("Anna kolmas luku ");
                luku3 = int.Parse(Console.ReadLine());

            summa = luku1+luku2+luku3;
            keskiarvo = summa / 3;
            Console.WriteLine("Yhteensä: {0} ja keskiarvo {1}", summa, keskiarvo);
            


        }
    }
}
