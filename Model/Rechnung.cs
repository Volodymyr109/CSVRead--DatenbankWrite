using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatenbankReader.Model
{
    public class Rechnung
    {
        public int? RechnungId { get; set; }

        public string? KundenNr { get; set; }

        public int? KundenId { get; set; }

        public string? ArtikelNr { get; set; }

        public int? ArtikelId { get; set; }

        public int? Anzahl { get; set; }

        public Rechnung() { }

        public Rechnung(int? rechnungId = null, int? kundenId = null, string? kundenNr = null, int? artikelId = null, string? artikelNr = null, int? anzahl = null)
        {
            RechnungId = rechnungId;
            KundenId = kundenId;
            KundenNr = kundenNr;
            ArtikelId = artikelId;
            ArtikelNr = artikelNr;
            Anzahl = anzahl;
        }
    }
}
