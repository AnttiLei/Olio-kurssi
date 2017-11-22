using System;
using System.Collections.Generic;
using System.Text;

namespace Kertaustehtävä
{
    public class Opiskelija
    {
        public string Etunimi { get; set; }
        public string Sukunimi { get; set; }
        private static int oplkm = 0;
        public Opiskelija(string etunimi, string sukunimi)
        {
            Etunimi = etunimi;
            Sukunimi = sukunimi;
            this.Etunimi = etunimi;
            oplkm++;
        }
        public static int Montako()
        {
            return oplkm;
        }

        Opiskelija otto = new Opiskelija("Otto", "Opiskelija");
        Opiskelija tero = new Opiskelija("Tero", "Terävä");
        Opiskelija kari = new Opiskelija("Kari", "Kärki");

        public override string ToString()
        {
            return Etunimi + " " + Sukunimi;
        }
    }
}
