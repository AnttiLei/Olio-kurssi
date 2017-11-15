using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VKO44Tunti
{
    interface Icalculator

    public class MyCalculator : Icalculator
    {
        public int Add(int number1, int number2);
    }
    class Program
    {
        static void Main(string[] args)
        {
            MyCalculator laskin = new MyCalculator();
            int luku1 = 10;
            int luku2 = 20;
            Console.WriteLine("Lukujen {0} ja {1} summa on {2}", luku1, luku2, laskin.Add)
        }
    }
}
