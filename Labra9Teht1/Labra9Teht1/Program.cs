using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labra9Teht1
{
    class Program
    {
        static void Main(string[] args)
        {
            ThrowDice();
        }
        static void ThrowDice()
        {
            Dice dice = new Dice();

            dice.Throw();

            dice.Randomize();

            Console.WriteLine(dice.ToString());
        }
    }
}
