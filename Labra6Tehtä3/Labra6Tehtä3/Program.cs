using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labra6Tehtä3
{
    class Program
    { 

     static void Main(string[] args)
     {

         Console.WriteLine("Seuran pelaajat:");

         List<Pelaaja> Pelaajat = new List<Pelaaja>();
            foreach (Pelaaja item in Pelaajat)
            {
            Console.WriteLine(item.ToString());
            }
                 
           

           Seura jyp = new Seura();
             jyp.Nimi = "JYP";
             jyp.Pelaajat.Add(new Pelaaja("Timo", "Taikuri", "P", "L"));
           Console.WriteLine(jyp.ToString());

        }
    }

}