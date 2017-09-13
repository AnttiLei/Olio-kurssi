using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tehtävä1
{
    class Teht1
    {
        static void Tehtävä1(string[] args)
        {
            int luku;
            Console.WriteLine("Anna luku > ");
            luku = int.Parse(Console.ReadLine());
            
            if (luku == 1)
            {
                Console.WriteLine("Annoit luvun yksi");
            }
            if (luku == 2)
            {
                Console.WriteLine("Annoit luvun kaksi");
            }
            if (luku == 3)
            {
                Console.WriteLine("Annoit luvun kolme");
            }
            else if(luku > 3)
            {
                Console.WriteLine("Joku muu luku");
            }
        }
    }
}
