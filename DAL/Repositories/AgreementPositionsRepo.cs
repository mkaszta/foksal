using BLL;
using BLL.Entities;
using System;
using System.Data;
using System.Data.SqlClient;

namespace DAL.Repositories
{
    public class AgreementPositionsRepo
    {
        public static AgreementPosition GetByID(int Id)
        {
            AgreementPosition position = new AgreementPosition();

            using (SqlConnection dbConnection = new DBConnection().Connection)
            {
                string sqlQuery = string.Format("SELECT * FROM [vPozycjeUmowy] WHERE [Id] = '{0}' ", Id);

                using (SqlCommand command = new SqlCommand(sqlQuery, dbConnection))
                {
                    SqlDataReader reader = command.ExecuteReader();

                    while (reader.Read())
                    {
                        position.Id = Id;
                        position.AgreementId = reader.GetInt32(reader.GetOrdinal("UmowaId"));
                        position.Title = reader.GetString(reader.GetOrdinal("Tytul")).Equals(string.Empty) ? "(...)" : reader.GetString(reader.GetOrdinal("Tytul"));
                        position.SettlementModelId = reader.GetInt32(reader.GetOrdinal("ModelId"));
                        position.KTM = reader.GetString(reader.GetOrdinal("KTM"));
                        position.Descriptor = reader.GetString(reader.GetOrdinal("Deskryptor"));
                        position.CurrencyId = reader.GetInt32(reader.GetOrdinal("WalutaId"));
                        position.BillingPeriodStart = reader.IsDBNull(reader.GetOrdinal("PoczatekOkresuRozliczeniowego")) ? (DateTime?)null : reader.GetDateTime(reader.GetOrdinal("PoczatekOkresuRozliczeniowego"));
                        position.BillingPeriodEnd = reader.IsDBNull(reader.GetOrdinal("KoniecOkresuRozliczeniowego")) ? (DateTime?)null : reader.GetDateTime(reader.GetOrdinal("KoniecOkresuRozliczeniowego"));
                        position.IsIndifinitePeriod = reader.GetBoolean(reader.GetOrdinal("UmowaNaCzasOkreslony"));
                        position.IsChargedFromFirstSale = reader.GetBoolean(reader.GetOrdinal("NaliczanieOdPierwszejSprzedazy"));
                        position.BillingPeriod = reader.GetByte(reader.GetOrdinal("OkresRozliczeniowy"));
                        position.FreeCopies = reader.GetInt32(reader.GetOrdinal("LiczbaEgzemplarzyBezOplat"));
                        position.ExpirationDate = reader.IsDBNull(reader.GetOrdinal("DataZakonczeniaKontraktu")) ? (DateTime?)null : reader.GetDateTime(reader.GetOrdinal("DataZakonczeniaKontraktu"));
                        position.WFMagDeliveryDate = reader.IsDBNull(reader.GetOrdinal("Data_dostawy")) ? (DateTime?)null : reader.GetDateTime(reader.GetOrdinal("Data_dostawy"));
                        position.WFMagFirstSaleDate = reader.IsDBNull(reader.GetOrdinal("DataPierwszejSprzedazy")) ? (DateTime?)null : reader.GetDateTime(reader.GetOrdinal("DataPierwszejSprzedazy"));
                        position.WFMagNetto = reader.GetDecimal(reader.GetOrdinal("DetalNetto"));
                        position.WFMagBrutto = reader.GetDecimal(reader.GetOrdinal("DetalBrutto"));
                        position.WFMagPZ = reader.GetDecimal(reader.GetOrdinal("IloscPz"));
                        position.ModelPercent = reader.GetDecimal(reader.GetOrdinal("ProcentOdCeny"));
                        position.ModelFixedPrice = reader.GetDecimal(reader.GetOrdinal("StalaCena"));
                    }
                }
            }

            return position;
        }

        public static void InsertUpdate(AgreementPosition position)
        {
            using (SqlConnection dbConnection = new DBConnection().Connection)
            {
                string sqlQuery = "";

                if (position.Id > 0)
                {
                    sqlQuery = string.Format("UPDATE [PozycjaUmowy] " +
                    "SET KTM = @ktm, Deskryptor = @deskryptor, ModelId = @modelId, WalutaId = @walutaId, PoczatekOkresuRozliczeniowego = @poczatekOkresuRozliczeniowego, " +
                    "UmowaNaCzasOkreslony = @umowaNaCzasOkreslony, KoniecOkresuRozliczeniowego = @koniecOkresuRozliczeniowego, OkresRozliczeniowy = @okresRozliczeniowy, " +
                    "NaliczanieOdPierwszejSprzedazy = @naliczanieOdPierwszejSprzedazy, LiczbaEgzemplarzyBezOplat = @liczbaEgzemplarzyBezOplat, " +
                    "DataZakonczeniaKontraktu = @dataZakonczeniaKontraktu, StalaCena = @stalaCena, ProcentOdCeny = @procentOdCeny, Uwagi = @uwagi, " +
                    "EdycjaUzytkownik = @uzytkownik " +
                    "WHERE Id = @id");
                }
                else
                {
                    sqlQuery = string.Format("INSERT INTO [PozycjaUmowy] (UmowaId, KTM, Deskryptor, ModelId, WalutaId, PoczatekOkresuRozliczeniowego, " +
                    "UmowaNaCzasOkreslony, KoniecOkresuRozliczeniowego, OkresRozliczeniowy, NaliczanieOdPierwszejSprzedazy, LiczbaEgzemplarzyBezOplat, " +
                    "DataZakonczeniaKontraktu, StalaCena, ProcentOdCeny, Uwagi, WprowadzenieUzytkownik) " +
                    "VALUES (@umowaId, @ktm, @deskryptor, @modelId, @walutaId, @poczatekOkresuRozliczeniowego, " +
                    "@umowaNaCzasOkreslony, @koniecOkresuRozliczeniowego, @okresRozliczeniowy, @naliczanieOdPierwszejSprzedazy, @liczbaEgzemplarzyBezOplat, " +
                    "@dataZakonczeniaKontraktu, @stalaCena, @procentOdCeny, @uwagi, @uzytkownik)");
                }

                using (SqlCommand command = new SqlCommand(sqlQuery, dbConnection))
                {
                    command.Parameters.Add("@id", SqlDbType.Int, 6).Value = position.Id;
                    command.Parameters.Add("@umowaId", SqlDbType.Int, 6).Value = position.AgreementId;
                    command.Parameters.Add("@ktm", SqlDbType.VarChar, 50).Value = position.KTM;
                    command.Parameters.Add("@deskryptor", SqlDbType.VarChar, 50).Value = position.Descriptor;
                    command.Parameters.Add("@modelId", SqlDbType.Int, 6).Value = position.SettlementModelId;
                    command.Parameters.Add("@walutaId", SqlDbType.Int, 6).Value = position.CurrencyId;
                    command.Parameters.Add("@okresRozliczeniowy", SqlDbType.TinyInt, 6).Value = position.BillingPeriod;
                    command.Parameters.Add("@poczatekOkresuRozliczeniowego", SqlDbType.DateTime, 8).Value = position.BillingPeriodStart;
                    command.Parameters.Add("@koniecOkresuRozliczeniowego", SqlDbType.DateTime, 8).Value = position.BillingPeriodEnd;
                    command.Parameters.Add("@naliczanieOdPierwszejSprzedazy", SqlDbType.Bit, 6).Value = position.IsChargedFromFirstSale;
                    command.Parameters.Add("@umowaNaCzasOkreslony", SqlDbType.Bit, 6).Value = position.IsIndifinitePeriod;
                    command.Parameters.Add("@liczbaEgzemplarzyBezOplat", SqlDbType.Int, 6).Value = position.FreeCopies;
                    command.Parameters.Add("@dataZakonczeniaKontraktu", SqlDbType.DateTime, 8).Value = position.ExpirationDate;
                    command.Parameters.Add("@stalaCena", SqlDbType.Decimal, 10).Value = position.ModelFixedPrice;
                    command.Parameters.Add("@procentOdCeny", SqlDbType.Decimal, 10).Value = position.ModelPercent;
                    command.Parameters.Add("@uwagi", SqlDbType.VarChar, 1000).Value = position.Comments;
                    command.Parameters.Add("@uzytkownik", SqlDbType.Int, 6).Value = AppUser.Instance.UserId;                    

                    command.ExecuteNonQuery();
                }
            }
        }
    }
}
