using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatenbankReader.Model
{
    public class Artikel
    {
        public int? ArtikelId { get; set; }

        public string? ArtikelNr { get; set; }

        public string? Name { get; set; }

        public decimal? Preis { get; set; }

        public Artikel () { }

        public Artikel (int? artikelId = null, string? artikelNr = null, string? name = null, decimal? preis = null)
        {
            ArtikelId = artikelId;
            ArtikelNr = artikelNr;
            Name = name;
            Preis = preis;
        }
    }
}
