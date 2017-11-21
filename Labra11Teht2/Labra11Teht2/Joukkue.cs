using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labra11Teht2
{
    public static class Joukkue
    {
        public static List<Pelaaja> HaePelaajat()
        {
            List<Pelaaja> pelaajat = new List<Pelaaja>();
            
            pelaajat.Add(new Pelaaja("Eetu", "Laurikainen", "Left", 41));
            pelaajat.Add(new Pelaaja("Juho", "Olkinuora", "Left", 45));
            pelaajat.Add(new Pelaaja("Anttoni", "Honka", "Right", 3));
            pelaajat.Add(new Pelaaja("Juuso", "Vainio", "Right", 5));
            pelaajat.Add(new Pelaaja("Mikko", "Kalteva", "Left", 7));
            pelaajat.Add(new Pelaaja("Jaakko", "Jokinen", "Left", 16));
            pelaajat.Add(new Pelaaja("Alex", "Lindroos", "Left", 34));
            pelaajat.Add(new Pelaaja("Ronji", "Allen", "Left", 36));
            pelaajat.Add(new Pelaaja("Ossi", "Ikonen", "Left", 37));
            pelaajat.Add(new Pelaaja("Nolan", "Yonkman", "Right", 43));
            pelaajat.Add(new Pelaaja("Mikko", "MÃ¤enpÃ¤Ã¤", "Left", 47));
            pelaajat.Add(new Pelaaja("Joona", "Erving", "Left", 53));
            pelaajat.Add(new Pelaaja("Olli", "Aitola", "Left", 60));
            pelaajat.Add(new Pelaaja("Tuomas", "Salmela", "Left", 61));
            pelaajat.Add(new Pelaaja("Mikko", "Kuukka", "Left", 91));
            pelaajat.Add(new Pelaaja("Joonas", "NÃ¤ttinen", "Right", 9));
            pelaajat.Add(new Pelaaja("Samuli", "Ratinen", "Left", 11));
            pelaajat.Add(new Pelaaja("Jani", "Tuppurainen", "Left", 12));
            pelaajat.Add(new Pelaaja("Antti", "Suomela", "Left", 14));
            pelaajat.Add(new Pelaaja("Juha-Pekka", "HytÃ¶nen", "Left", 15));
            pelaajat.Add(new Pelaaja("Juuso", "Puustinen", "Right", 17));
            pelaajat.Add(new Pelaaja("Valtteri", "Hotakainen", "Left", 21));
            pelaajat.Add(new Pelaaja("Ossi", "Louhivaara", "Right", 23));
            pelaajat.Add(new Pelaaja("Jarkko", "Immonen", "Right", 26));
            pelaajat.Add(new Pelaaja("Riku", "Tiainen", "Left", 27));
            pelaajat.Add(new Pelaaja("Miika", "Lahti", "Left", 28));
            pelaajat.Add(new Pelaaja("Joel", "Sund", "Right", 29));
            pelaajat.Add(new Pelaaja("Arttu", "Likola", "Left", 31));
            pelaajat.Add(new Pelaaja("Jerry", "Turkulainen", "Right", 32));
            pelaajat.Add(new Pelaaja("Micke", "Saari", "Left", 40));
            pelaajat.Add(new Pelaaja("Janne", "Kolehmainen", "Left", 55));
            pelaajat.Add(new Pelaaja("Henri", "Kanninen", "Left", 71));
            pelaajat.Add(new Pelaaja("Robert", "Rooba", "Left", 88));
            return pelaajat;
        }

    }

    public class Pelaaja
    {
        public string Etunimi { get; set; }
        public string Sukunimi { get; set; }
        public string Katisyys { get; set; }
        public int Numero { get; set; }
        public Pelaaja()
        {

        }

        public Pelaaja(string enimi, string snimi, string hand, int num)
        {
            Etunimi = enimi;
            Sukunimi = snimi;
            Katisyys = hand;
            Numero = num;
        }
        public override string ToString()
        {
            return Etunimi + "," + Sukunimi + "," + Katisyys + "," + Numero;
        }
    }

    

    
}

