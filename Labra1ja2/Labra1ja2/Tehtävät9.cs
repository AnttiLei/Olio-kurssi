using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tehtävä9
{
    class Teht9
    {
        static void Tehtävä9(string[] args)
        {
            string strNum;
            int num;
            int i = 0;
            int sum = 0;

            do 
            {
                Console.WriteLine("Anna kokonaisnumero, 0 lopettaa."); 
                strNum = Console.ReadLine();
                if (int.TryParse(strNum, out num)) 
                {
                    if (num > 0)
                    {
                        i++;
                        sum += num;
                        continue;
                    }
                    else
                    {
                        Console.WriteLine("Yhteensä {0}",sum); 
                        break;
                    }
                }
            }
            while (i > 0);
        }
    }
}
