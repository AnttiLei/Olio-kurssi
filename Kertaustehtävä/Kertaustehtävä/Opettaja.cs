using System;
using System.Collections.Generic;
using System.Text;

namespace Kertaustehtävä
{
    public class Opettaja : Opiskelija
    {
        public string Titteli { get; set; }

        public Opettaja(string titteli, string etunimi, string sukunimi) : base(etunimi, sukunimi)
        {
            Titteli = titteli;
        }

        Opettaja olli = new Opettaja("Matikanope", "Olli", "Opettaja");
        Opettaja toni = new Opettaja("Fysiikanope", "Toni", "Tohtori");

        public override string ToString()
        {
            return Titteli + " " + Etunimi + " " + Sukunimi;
        }

    }
}
