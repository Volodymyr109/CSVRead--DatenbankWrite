using DatenbankReader.Logic;
using DatenbankReader.Model;
using Npgsql;
using System.Data.Common;
using System.Linq;
using System.Text;

class Program
{

    static void Main(string[] args)
    {

        string connectionString = "YourDatabaseConnectionString";
        using (var conn = new NpgsqlConnection(connectionString))
        {
            conn.Open();

            CSVReadWrite csv = new CSVReadWrite();
            DBReadWrite db = new DBReadWrite();

            ProcessKunde(csv, db);
            ProcessArtikel(csv, db);
            ProcessRechnung(csv, db);

            GesamtbetragProKunde(conn);

        }
    }

        public static void ProcessKunde(CSVReadWrite csv, DBReadWrite db)
    {
        List<Kunde> kunden = csv.KundeFromCSV();

        foreach (var kunde in kunden)
        {
            db.WriteKundeToDatabase(kunde);
        }
    }

    public static void ProcessArtikel(CSVReadWrite csv, DBReadWrite db)
    {
        List<Artikel> artikel = csv.ArtikelFromCSV();

        foreach (var a in artikel)
        {
            db.WriteArtikelToDatabase(a);
        }
    }

    public static void ProcessRechnung(CSVReadWrite csv, DBReadWrite db)
    {
        List<Rechnung> rechnungen = csv.RechnungFromCSV();

        foreach (var rechnung in rechnungen)
        {
            db.WriteRechnungToDatabase(rechnung);
        }
    }

    
    public static void GesamtbetragProKunde(NpgsqlConnection _conn)
    {
        using (var cmd = new NpgsqlCommand("SELECT k.kundenid, k.name AS kundenname, SUM(r.anzahl * a.preis) AS gesamtbetrag " +
                                          "FROM kunde k " +
                                          "JOIN rechnung r ON k.kundenid = r.kundenid " +
                                          "JOIN artikel a ON r.artikelid = a.artikelid " +
                                          "GROUP BY k.kundenid, k.name", _conn))

        using (var reader = cmd.ExecuteReader())
        {
            Console.WriteLine("---------------Gesamtbetrag--------------");
            Console.WriteLine("Gesamtbetrag pro Kunde:");
            while (reader.Read())
            {
                int kundenId = reader.GetInt32(0);
                string kundenname = reader.GetString(1);

                // Check if gesamtbetrag is null
                if (!reader.IsDBNull(2))
                {
                    double gesamtbetrag = reader.GetDouble(2);
                    Console.WriteLine($"Kunde: {kundenname}, Gesamtbetrag: {gesamtbetrag:C}");
                }
                else
                {
                    Console.WriteLine($"Kunde: {kundenname}, Gesamtbetrag: N/A (NULL)");
                }
            }
        }
    }
}
