using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labra4Tehtä4
{
    class Boss : Staff
    {
        public string Car { get; set; }
        public int Bonus { get; set; }

        public Boss(string firstName, string lastName, string profession, int salary, string car, int bonus) : base(firstName, lastName, profession, salary)
        {
            Car = car;
            Bonus = bonus;

        }


    }
}
