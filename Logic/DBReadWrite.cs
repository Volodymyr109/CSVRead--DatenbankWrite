using DatenbankReader.Model;
using Npgsql;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatenbankReader.Logic
{
    public class DBReadWrite
    {

        private NpgsqlConnection _connection;

        public DBReadWrite()
        {
            _connection = new NpgsqlConnection("Server=192.168.1.236;Port=5432;Database=ausbildung;User Id=nicetec;Password=nicetec;");
        }
        public void WriteArtikelToDatabase(Artikel artikel)
        {
            try
            {
                if (_connection.State != System.Data.ConnectionState.Open)
                {
                    _connection.Open();
                }

                NpgsqlCommand cmd = _connection.CreateCommand();

                cmd.CommandText = "INSERT INTO artikel (artikelnr, name, preis) values (@artikelnr, @name, @preis)";

                //NpgsqlParameter paramArtikelId = new NpgsqlParameter();
                //paramArtikelId.NpgsqlDbType = NpgsqlTypes.NpgsqlDbType.Varchar;
                //paramArtikelId.ParameterName = "@artikelid";
                //paramArtikelId.NpgsqlValue = artikel.ArtikelId;

                //cmd.Parameters.Add(paramArtikelId);

                NpgsqlParameter paramArtikelNr = new NpgsqlParameter();
                paramArtikelNr.NpgsqlDbType = NpgsqlTypes.NpgsqlDbType.Varchar;
                paramArtikelNr.ParameterName = "@artikelnr";
                paramArtikelNr.NpgsqlValue = artikel.ArtikelNr;

                cmd.Parameters.Add(paramArtikelNr);

                NpgsqlParameter paramName = new NpgsqlParameter();
                paramName.NpgsqlDbType = NpgsqlTypes.NpgsqlDbType.Varchar;
                paramName.ParameterName = "@name";
                paramName.NpgsqlValue = artikel.Name;

                cmd.Parameters.Add(paramName);

                NpgsqlParameter paramPreis = new NpgsqlParameter();
                paramPreis.NpgsqlDbType = NpgsqlTypes.NpgsqlDbType.Numeric;
                paramPreis.ParameterName = "@preis";
                paramPreis.NpgsqlValue = artikel.Preis;

                cmd.Parameters.Add(paramPreis);

                cmd.ExecuteNonQuery();

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
            finally
            {
                if (_connection != null)
                {
                    _connection.Close();
                }
            }
        }

        public void WriteKundeToDatabase(Kunde kunde)
        {
            try
            {
                if (_connection.State != System.Data.ConnectionState.Open)
                {
                    _connection.Open();
                }

                NpgsqlCommand cmd = _connection.CreateCommand();

                cmd.CommandText = "INSERT INTO kunde (kundenNr, name, strasse, ort) values (@kundenNr, @name, @strasse ,@ort)";

                NpgsqlParameter paramKundenNr = new NpgsqlParameter();
                paramKundenNr.NpgsqlDbType = NpgsqlTypes.NpgsqlDbType.Varchar;
                paramKundenNr.ParameterName = "@kundenNr";
                paramKundenNr.NpgsqlValue = kunde.KundenNr;

                cmd.Parameters.Add(paramKundenNr);

                NpgsqlParameter paramName = new NpgsqlParameter();
                paramName.NpgsqlDbType = NpgsqlTypes.NpgsqlDbType.Varchar;
                paramName.ParameterName = "@name";
                paramName.NpgsqlValue = kunde.Name;

                cmd.Parameters.Add(paramName);

                NpgsqlParameter paramStrasse = new NpgsqlParameter();
                paramStrasse.NpgsqlDbType = NpgsqlTypes.NpgsqlDbType.Varchar;
                paramStrasse.ParameterName = "@strasse";
                paramStrasse.NpgsqlValue = kunde.Strasse;

                cmd.Parameters.Add(paramStrasse);

                NpgsqlParameter paramOrt = new NpgsqlParameter();
                paramOrt.NpgsqlDbType = NpgsqlTypes.NpgsqlDbType.Varchar;
                paramOrt.ParameterName = "@ort";
                paramOrt.NpgsqlValue = kunde.Ort;

                cmd.Parameters.Add(paramOrt);

                cmd.ExecuteNonQuery();

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
            finally
            {
                if (_connection != null)
                {
                    _connection.Close();
                }
            }
        }

        public void WriteRechnungToDatabase(Rechnung rechnung)
        {
            try
            {
                if (_connection.State != System.Data.ConnectionState.Open)
                {
                    _connection.Open();
                }
                NpgsqlCommand cmd = _connection.CreateCommand();

                cmd.CommandText = @"
                    INSERT INTO rechnung (kundenID, artikelID, anzahl) VALUES
                    ( (SELECT max(k.kundenID) FROM kunde k where k.kundennr = @kundenNr),
                      (SELECT max(a.artikelid)  FROM artikel a where a.artikelnr = @artikelNr)  , @anzahl)";

                NpgsqlParameter paramKundenNr = new NpgsqlParameter();
                paramKundenNr.NpgsqlDbType = NpgsqlTypes.NpgsqlDbType.Varchar;
                paramKundenNr.ParameterName = "@kundenNr";
                paramKundenNr.NpgsqlValue = rechnung.KundenNr;

                cmd.Parameters.Add(paramKundenNr);

                NpgsqlParameter paramArtikelNr = new NpgsqlParameter();
                paramArtikelNr.NpgsqlDbType = NpgsqlTypes.NpgsqlDbType.Varchar;
                paramArtikelNr.ParameterName = "@artikelNr";
                paramArtikelNr.NpgsqlValue = rechnung.ArtikelNr;

                cmd.Parameters.Add(paramArtikelNr);

                NpgsqlParameter paramAnzahl = new NpgsqlParameter();
                paramAnzahl.NpgsqlDbType = NpgsqlTypes.NpgsqlDbType.Integer;
                paramAnzahl.ParameterName = "@anzahl";
                paramAnzahl.NpgsqlValue = rechnung.Anzahl;

                cmd.Parameters.Add(paramAnzahl);


                cmd.ExecuteNonQuery();

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
            finally
            {
                if (_connection != null)
                {
                    _connection.Close();
                }
            }
        }
    }
}
