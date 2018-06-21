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
                        position.BillingPeriodStart = reader.GetDateTime(reader.GetOrdinal("PoczatekOkresuRozliczeniowego"));
                        position.BillingPeriodEnd = reader.GetDateTime(reader.GetOrdinal("KoniecOkresuRozliczeniowego"));
                        position.IsIndifinitePeriod = reader.GetBoolean(reader.GetOrdinal("UmowaNaCzasOkreslony"));
                        position.IsChargedFromFirstSale = reader.GetBoolean(reader.GetOrdinal("NaliczanieOdPierwszejSprzedazy"));
                        position.BillingPeriod = reader.GetByte(reader.GetOrdinal("OkresRozliczeniowy"));
                        position.FreeCopies = reader.GetInt32(reader.GetOrdinal("LiczbaEgzemplarzyBezOplat"));
                        position.AgreementExpirationDate = reader.GetDateTime(reader.GetOrdinal("DataZakonczeniaKontraktu"));                        
                    }
                }
            }

            return position;
        }
    }
}
