using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tehtävä8
{
    class Program
    {
        static void Main(string[] args)
        {
            //Tee ohjelma, joka kysyy käyttäjältä 3 kokonaislukua ja tulostaa niistä suurimman.

            int l1, l2, l3;
            Console.WriteLine("Anna kokonaisluku ");
            l1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Anna kokonaisluku ");
            l2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Anna kokonaisluku ");
            l3 = int.Parse(Console.ReadLine());
            if (l1 < l2)
            {
                if (l1 < l3)
                    if (l2 < l3)
                        
                        Console.WriteLine("Suurin luku on {0}", l3);

                    else
                        Console.WriteLine("Suurin luku on {0}", l2);
                else
                    Console.WriteLine("Suurin luku on {0}", l2);


            }
            else
        if (l2 < l3)
                if (l1 < l3)
                    Console.WriteLine("Suurin luku on {0}", l3);
                else
                    Console.WriteLine("Suurin luku on {0}", l1);
            else
                Console.WriteLine("Suurin luku on {0}", l1);
        }
    }
}
