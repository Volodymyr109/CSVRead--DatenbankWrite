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

        /*
        if (args.Length != 1)
        {
            Console.WriteLine("Info - DatenbankReader");
            Console.WriteLine("-artikel   Auslesen der Artikel");
        }
        else
        {
            CSVReadWrite csv = new CSVReadWrite();
            DBReadWrite db = new DBReadWrite();

            switch (args[0])
            {
                case "-kunde":
                    ProcessKunde(csv, db);
                    break;
                case "-artikel":
                    ProcessArtikel(csv, db);
                    break;
                case "-rechnung":
                    ProcessRechnung(csv, db);
                    break;
                case "-all":
                    ProcessKunde(csv, db);
                    ProcessArtikel(csv, db);
                    ProcessRechnung(csv, db);
                    break;
                default:
                    Console.WriteLine("Ungültige Option: " + args[0]);
                    break;
            }
        }*/

        // FUER GESAMTBETRAG
        string connString = "Server=192.168.1.236;Port=5432;Database=ausbildung;User Id=nicetec;Password=nicetec;";

        if (args.Length != 1)
        {
            Console.WriteLine("Info - DatenbankReader");
            Console.WriteLine("-artikel   Auslesen der Artikel");
        }
        else
        {
            CSVReadWrite csv = new CSVReadWrite();
            DBReadWrite db = new DBReadWrite();

            if (args[0] == "-kunde")
            {
                ProcessKunde(csv, db);               
            }
            else if (args[0] == "-artikel")
            {
                ProcessArtikel(csv, db);
            }
            else if (args[0] == "-rechnung")
            {
                ProcessRechnung(csv, db);
            }
            else if(args[0] == "-all")
            {
                ProcessKunde(csv, db);
                ProcessArtikel(csv, db);
                ProcessRechnung(csv, db);

                using (NpgsqlConnection conn = new NpgsqlConnection(connString))
                {
                    conn.Open();
                    GesamtbetragProKunde(conn);
                    conn.Close();
                }
            }
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