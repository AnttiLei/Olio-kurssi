﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labra6Tehtä3
{
    class Pelaaja
    {
        public string Etunimi { get; set; }
        public string Sukunimi { get; set; }
        public string Pelipaikka { get; set; }
        public string Kätisyys { get; set; }



        public Pelaaja(string etunimi, string sukunimi, string pelipaikka, string kätisyys)
        {
            Etunimi = etunimi;
            Sukunimi = sukunimi;
            Pelipaikka = pelipaikka;
            Kätisyys = kätisyys;
        }

        public override string ToString()
        {
            return Etunimi + " " + Sukunimi + " " + Pelipaikka + " " + Kätisyys;
        }

    }

    class Seura
    {
        public string Nimi { get; set; }
        public string Kaupunki { get; set; }
        //public string Kokoelma { get; set; }

        public List<Pelaaja> Pelaajat;
        public Seura() 
        {
        Pelaajat = new List<Pelaaja>();
        Pelaajat.Add(new Pelaaja("Antti", "Leinonen", "MV", "R"));
        Pelaajat.Add(new Pelaaja("Lantti", "Markkanen", "H", "R"));
        }

        public override string ToString()
        {
            string retval = "Joukkue " + Nimi + " sisältää pelaajat\n";
            foreach (Pelaaja item in Pelaajat)
            {
                retval += item.ToString() + "\n";
            }
            return retval;
        }

        public Seura(string nimi, string kaupunki)
        {
            Nimi = nimi;
            Kaupunki = kaupunki;
            //Kokoelma = kokoelma;

        }
    }

}
    
