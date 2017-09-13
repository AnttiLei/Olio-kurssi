using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tehtävä2
{
    class Program
    {
        static void Main(string[] args)
        {
            int numero;
            Console.WriteLine("Anna pistemäärä ");
            numero = int.Parse(Console.ReadLine());
            string arvosana;

            if (numero == 0 || numero == 1)
            {
                arvosana = "Koulunumero on 0";
                Console.WriteLine(arvosana);
            }
            else if (numero == 2 || numero == 3)
            {
                arvosana = "Koulunumero on 1";
                Console.WriteLine(arvosana);
            }
            else if (numero == 4 || numero == 5)
            {
                arvosana = "Koulunumero on 2";
                Console.WriteLine(arvosana);
            }
            else if (numero == 6 || numero == 7)
            {
                arvosana = "Koulunumero on 3";
                Console.WriteLine(arvosana);

            }
            else if (numero == 8 || numero == 9)
            {
                arvosana = "Koulunumero on 4";
                Console.WriteLine(arvosana);
            }
            else if (numero == 10 || numero == 12)
            {
                arvosana = "Koulunumero on 5";
                Console.WriteLine(arvosana);
            }

            else
            {
                arvosana = "ei mahdollinen";
                Console.WriteLine(arvosana);
            }
        }
    }
}
