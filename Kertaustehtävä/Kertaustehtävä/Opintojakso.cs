using System;
using System.Collections.Generic;
using System.Text;

namespace Kertaustehtävä
{
    class Opintojakso
    {
        public void LisääOpiskelija(Opiskelija uusi)
        {
            opiskelijat.Add(uusi);
        }

        public List<Opiskelija> NäytäOpiskelijat()
        {
            return opiskelijat;
        }

        List<Opiskelija> opiskelijat = new List<Opiskelija>();
        List<Opettaja> opettajat = new List<Opettaja>();

       

        

        
    }
}
