using BLL;
using BLL.Entities;
using System;
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
                        position.Title = reader.GetString(reader.GetOrdinal("Tytul"));
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
                        position.AgreementExpirationDate = reader.IsDBNull(reader.GetOrdinal("DataZakonczeniaKontraktu")) ? (DateTime?)null : reader.GetDateTime(reader.GetOrdinal("DataZakonczeniaKontraktu"));
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
    }
}
