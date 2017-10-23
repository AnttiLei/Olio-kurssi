using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAbra7Tehtä2
{
    class Program
    {
      
        static void Main(string[] args)
        {

            //Luodaan List-tyyppinen lista levyistä
            List<Cd> levy = new List<Cd>();
            
            levy.Add(new Cd("Endless Forms Most Beatiful", "Nightwish", "Kappale1, 4:40 kappale2 4:40, kappale3 4:40"));
            levy.Add(new Cd("Tosi hyvä levy", "Paikallinen bändi", "Kappale1, 2:40 kappale2 2:40, kappale3 2:40"));
            levy.Add(new Cd("Toisiks paras levy", "Paikallinen bändi", "Kappale1, 3:40 kappale2 3:40, kappale3 3:40"));


            //kaikkien levyjen tiedot
            Console.WriteLine("Jukeboksin levyt");
            foreach (var o in levy)
            {
                Console.WriteLine(o.ToString());
            }

        }
    }
    
}
