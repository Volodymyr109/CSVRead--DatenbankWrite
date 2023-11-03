using DatenbankReader.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;


namespace DatenbankReader.Logic
{
    public class CSVReadWrite
    {
        public List<Kunde> KundeFromCSV()
        {
            List<Kunde> kunden = new List<Kunde>();

            using (StreamReader sr = new StreamReader("D:\\DatenbankReader\\DatenbankReader\\Files\\Kunden.csv", Encoding.UTF8))
            {
                string line;

                int index = 0;

                while ((line = sr.ReadLine()) != null)
                {
                    if (index != 0)
                    {
                        string[] parts = line.Split(';');

                        if (parts.Length == 4)
                        {
                            string kundenNr = parts[0];
                            string name = parts[1];
                            string strasse = parts[2];
                            string ort = parts[3];

                            kunden.Add(new Kunde(kundenNr: kundenNr, name: name, strasse: strasse, ort: ort));
                        }
                    }

                    index++;
                }
            }

            return kunden;
        }

        public List<Artikel> ArtikelFromCSV()
        {
            List<Artikel> artikeln = new List<Artikel>();

            using (StreamReader sr = new StreamReader("D:\\DatenbankReader\\DatenbankReader\\Files\\Artikel.csv", Encoding.UTF8))
            {
                string line;

                int index = 0;

                while ((line = sr.ReadLine()) != null)
                {
                    if (index != 0)
                    {
                        string[] parts = line.Split(';');

                        if (parts.Length == 3)
                        {
                            string artikelNr = parts[0];
                            string name = parts[1];
                            decimal preis = Convert.ToDecimal(parts[2]);

                            artikeln.Add(new Artikel(artikelNr: artikelNr, name: name, preis: preis));
                        }
                    }

                    index++;
                }
            }

            return artikeln;
        }

        public List<Rechnung> RechnungFromCSV()
        {
            List<Rechnung> rechnungen = new List<Rechnung>();

            using (StreamReader sr = new StreamReader("D:\\DatenbankReader\\DatenbankReader\\Files\\Rechnung.csv", Encoding.UTF8))
            {
                string line;

                int index = 0;

                while ((line = sr.ReadLine()) != null)
                {
                    if (index != 0)
                    {
                        string[] parts = line.Split(';');

                        if (parts.Length == 3)
                        {
                            string kundenNr = parts[0];
                            string artikelNr = parts[1];
                            int anzahl = Convert.ToInt32(parts[2]);

                            rechnungen.Add(new Rechnung(kundenNr: kundenNr, artikelNr: artikelNr, anzahl : anzahl));
                        }
                    }

                    index++;
                }
            }

            return rechnungen;
        }
    }

}