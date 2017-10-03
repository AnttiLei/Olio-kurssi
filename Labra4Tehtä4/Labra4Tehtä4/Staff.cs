using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labra4Tehtä4
{
    class Staff
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Profession { get; set; }
        public int Salary { get; set; }

        public Staff(string firstName, string lastName)
        {
            FirstName = FirstName;
            LastName = lastName;
        }
        public Staff(string firstName, string lastName, string profession, int salary)
        {
            FirstName = firstName;
            LastName = lastName;
            Profession = profession;
            Salary = salary;
        }
       
        public override string ToString()
        {
            return "Name: " + FirstName + " " + LastName + " Profession: " + Profession + " Salary: " + Salary;
        }
    }

  
}
