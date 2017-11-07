using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labra9teht2
{
    class Product
    {
        public string Ostoskori { get; set; }
        public double Hinta { get; set; }

        public Product(string ostoskori, double hinta)
        {
            Ostoskori = ostoskori;
            Hinta = hinta;
        }
                    
        public override string ToString()
        {
            return "Tuote : " + Ostoskori + " " + Hinta + "euroa";
               
        }
    }
}


