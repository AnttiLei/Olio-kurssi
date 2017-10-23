using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAbra7Tehtä2
{
    class Cd
    {
        #region PROPERTIES
        public string Nimi { get; set; }
        public string Artist { get; set; }
        public string Songs { get; set; }
        
        #endregion
        #region CONSTRUCTORS
        public Cd()
        { }
        public Cd(string nimi, string artist, string songs)
        {
            Nimi = nimi;
            Artist = artist;
            Songs = songs;
            
        }
       
        #endregion
        #region METHODS
        public override string ToString()
        {
            return string.Format("Levyn nimi: {0} Artisti: {1} Kappaleet: {2}", Nimi, Artist, Songs);
        }
        #endregion
    }
}
