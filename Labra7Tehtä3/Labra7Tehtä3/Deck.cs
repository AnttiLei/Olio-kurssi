using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labra7Tehtä3
{
    class Deck
    {
        public string Kortti { get; set; }

        public Deck(string kortti)
        {
            Kortti = kortti;
        }

        public override string ToString()
        {
            return string.Format("{0}", Kortti);
        }
    }
}
