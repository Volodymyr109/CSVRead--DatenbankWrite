using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatenbankReader.Model
{
    public class Kunde
    {
        public int? KundenId { get; set; }

        public string? KundenNr { get; set; }

        public string? Name { get; set; }

        public string? Strasse { get; set; }

        public string? Ort { get; set; }

        public Kunde() { }

        public Kunde(int? kundenId = null, string? kundenNr = null, string? name = null, string? strasse = null, string? ort = null)
        {
            KundenId = kundenId;
            KundenNr = kundenNr;
            Name = name;
            Strasse = strasse;
            Ort = ort;
        }
    }
}