using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labra9teht2
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Product> kori = new List<Product>();
            kori.Add(new Product("Maito", 1.4));
            kori.Add(new Product("Olvi kolomonen", 2.2));
            kori.Add(new Product("Voi", 3.2));
            kori.Add(new Product("Juusto", 4.2));

            Console.WriteLine("Ostoskori sisältää:");

            foreach (var o in kori)
            {
                Console.WriteLine(o.ToString());
                
            }
        }

    }
}
