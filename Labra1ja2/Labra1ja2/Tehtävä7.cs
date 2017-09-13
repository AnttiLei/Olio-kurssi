using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tehtävä_7
{
    class Teht7
    {
        static void Tehtävä7(string[] args)
        {
            //Tee ohjelma, joka näyttää onko annettu vuosi karkausvuosi. Vuosiluku kysytään käyttäjältä.
            //4:llä jaolliset on, paitsi täydet vuosisadat. Kuitenkin 400:lla jaolliset vuosisadat ovat

            int vuosi;
            Console.WriteLine("Anna vuosiluku");
            vuosi = int.Parse(Console.ReadLine());
            // vuoden jakojäännös neljällä on 0 JA vuoden jakojäännös sadalla on eri TAI vuoden jakojäännös 400:lla on nolla.
            if ((vuosi % 4 == 0 && vuosi % 100 != 0) || (vuosi % 400 == 0))
            {
                Console.WriteLine("{0} vuosi on karkausvuosi", vuosi);
            }
            else
            {
                Console.WriteLine("{0} ei ole karkausvuosi", vuosi);
            }
        }
    }
}
