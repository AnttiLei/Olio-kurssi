using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JAMK.IT.MiniASIO
{
    class TestaaMiniASIO
    {

        static void Testaa()
        {
            //Luodaan List-tyyppinen lista opiskelijoista
            List<Opiskelija> opiskelijat = new List<Opiskelija>();
            //Testin vuoksi erilaisia tapoja lisätä olioita listaan
            Opiskelija masa = new Opiskelija("Masa", "Niemi");
            opiskelijat.Add(masa);
            opiskelijat.Add(new Opiskelija("Allan", "Aalto", "A1234"));
            //myös näin
            opiskelijat.Add(new Opiskelija { Etunimi = "Hanna", Sukunimi = "Husso", AsioID = "H5678" });
            opiskelijat.Add(new Opiskelija { Etunimi = "Teppo", Sukunimi = "Testaaja", AsioID = "T9876", Ryhmä = "TTV17s1" });
            Opiskelija kalle = new Opiskelija();
            kalle.Etunimi = "Kalle"; kalle.Sukunimi = "Ankka"; kalle.AsioID = "K666"; opiskelijat.Add(kalle);
            //yhden opiskelijan tietojen näyttäminen
            Console.WriteLine("Anna numero väliltä 1-{0}", opiskelijat.Count);
            int i = int.Parse(Console.ReadLine());
            if (i-1 < opiskelijat.Count)
                Console.WriteLine("MiniASIOn {0} opiskelija on {1}", i, opiskelijat[i - 1].ToString());
            else
                Console.WriteLine("MiniASIOssa on vain {0} opiskelijaa", opiskelijat.Count);
            //kaikkien opiskelijoiden tiedot
            Console.WriteLine("MiniASIOn kaikki opiskelijat:");
            foreach (var o in opiskelijat)
            {
                Console.WriteLine(o.ToString());
            }
            //kaikkien opiskelijoitten tiedot aakkosjärjestyksessä sukunimen mukaan
            //sortataan oliot Sukunimi-ominaisuuden mukaiseen järjestykseen
            opiskelijat.Sort((x, y) => x.Sukunimi.CompareTo(y.Sukunimi));
            Console.WriteLine("MiniASIOn kaikki opiskelijat aakkosjärjestyksessä:");
            foreach (var o in opiskelijat)
            {
                Console.WriteLine(o.ToString());
            }
            //uuden opiskelijan lisääminen, huom tehdään tarkistus ettei AsioID ole jo olemassa
            Console.WriteLine("Anna uuden opiskelijan ASioID");
            string asioid = Console.ReadLine();
            //tutkitaan onko listassa 
            bool lippu = false;
            foreach (Opiskelija o in opiskelijat)
            {
                if (asioid == o.AsioID)
                {
                    lippu = true;
                    break;
                }
            }
            if (lippu)
            {
                Console.WriteLine("AsioID {0} on jo käytössä", asioid);
            }
            else
            {
                Console.WriteLine("Anna uuden opiskelijan etunimi");
                string etunimi = Console.ReadLine();
                Console.WriteLine("Anna uuden opiskelijan sukunimi");
                string sukunimi = Console.ReadLine();
                Console.WriteLine("Anna uuden opiskelijan ryhmä");
                string ryhma = Console.ReadLine();
                //luodaan uusi Opiskelija olio
                Opiskelija uusi = new Opiskelija(etunimi, sukunimi, asioid, ryhma);
                opiskelijat.Add(uusi);
                Console.WriteLine("MiniASIOn kaikki {0} opiskelijat:", opiskelijat.Count);
                foreach (var o in opiskelijat)
                {
                    Console.WriteLine(o.ToString());
                }
            }
        }

        static void Main(string[] args)
        {
            Testaa();
        }
    }
}
