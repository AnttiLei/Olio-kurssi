using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labra9Teht1
{
    class Dice
    {
        public int NumberOfThrows { get; set; }
        public int Number { get; set; }
        private const int minNumber = 1;
        private const int maxNumber = 7;
        private double average;
        private int[] count = new int[6];

        Random rnd = new Random();

        public void Throw()
        {
            Console.WriteLine("Ohjelma tulostaa heittojen tuloksien keskiarvon ja tuloksien määrät");
            Console.Write("Monta kertaa heitetään?: ");
            NumberOfThrows = int.Parse(Console.ReadLine());
        }
        public void Randomize()
        {
            for (int i = 0; i < NumberOfThrows; i++)
            {
                Number = rnd.Next(minNumber, maxNumber);

                average += Number;
                switch (Number)
                {
                    case 1: count[0]++; break;
                    case 2: count[1]++; break;
                    case 3: count[2]++; break;
                    case 4: count[3]++; break;
                    case 5: count[4]++; break;
                    case 6: count[5]++; break;
                    default:
                        break;
                }
            }
            average = average / NumberOfThrows;
        }

        public override string ToString()
        {
            return "Keskiarvo on: " + average + "\nHeittojen määrä: " + NumberOfThrows +
                "\n\tNumero 1 tuli: " + count[0] + " kertaa" +
                "\n\tNumero 2 tuli: " + count[1] + " kertaa" +
                "\n\tNumero 3 tuli: " + count[2] + " kertaa" +
                "\n\tNumero 4 tuli: " + count[3] + " kertaa" +
                "\n\tNumero 5 tuli: " + count[4] + " kertaa" +
                "\n\tNumero 6 tuli: " + count[5] + " kertaa";
        }
    }
}
