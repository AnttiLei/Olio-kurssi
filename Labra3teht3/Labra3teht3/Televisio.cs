using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labra3teht3
{
    class Televisio
    {
        public bool PowerOn { get; set; }
        public bool Volume { get; set; }
        int chan;
        public int Channel
        {
            get { return chan; }
            set
            {
                chan = value;
                if (chan < 1)
                {
                    chan = 1;
                }
                else if (chan > 100)
                {
                    chan = 1;
                }
            }
        }
    }
}
