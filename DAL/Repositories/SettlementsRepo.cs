using BLL;
using BLL.Entities;
using System;
using System.Data;
using System.Data.SqlClient;

namespace DAL.Repositories
{
    public class SettlementsRepo
    {        
        public static Settlement GetById(int settlementId)
        {
            Settlement settlement = new Settlement();

            using (SqlConnection dbConnection = new DBConnection().Connection)
            {
                string sqlQuery = string.Format("SELECT * FROM [RozliczenieUmowy] WHERE [Id] = {0}", settlementId);

                using (SqlCommand command = new SqlCommand(sqlQuery, dbConnection))
                {
                    SqlDataReader reader = command.ExecuteReader();

                    while (reader.Read())
                    {
                        settlement.Id = reader.GetInt32(reader.GetOrdinal("id"));
                        settlement.AmountToPayOut = reader.IsDBNull(reader.GetOrdinal("DoWyplaty")) ? (decimal?)null : reader.GetDecimal(reader.GetOrdinal("DoWyplaty"));
                        settlement.CertificateDate = reader.IsDBNull(reader.GetOrdinal("DataObowiazywaniaCertyfikatu")) ? (DateTime?)null : reader.GetDateTime(reader.GetOrdinal("DataObowiazywaniaCertyfikatu"));
                        settlement.Comments = reader.GetString(reader.GetOrdinal("Uwagi"));
                        settlement.DispatchDate = reader.IsDBNull(reader.GetOrdinal("DataWysylki")) ? (DateTime?)null : reader.GetDateTime(reader.GetOrdinal("DataWysylki"));
                        settlement.Email = reader.GetString(reader.GetOrdinal("AdresEmail"));
                        settlement.GenerationDate = reader.GetDateTime(reader.GetOrdinal("DataGenerowania"));
                        settlement.InvoiceAmount = reader.IsDBNull(reader.GetOrdinal("KwotaFaktury")) ? (decimal?)null : reader.GetDecimal(reader.GetOrdinal("KwotaFaktury"));
                        settlement.InvoiceNumber = reader.IsDBNull(reader.GetOrdinal("NumerFaktury")) ? "" : reader.GetString(reader.GetOrdinal("NumerFaktury"));                        
                        settlement.IsLocked = reader.GetBoolean(reader.GetOrdinal("Zablokowane"));
                        settlement.PurchaseOrder = reader.IsDBNull(reader.GetOrdinal("PurchaseOrder")) ? "" : reader.GetString(reader.GetOrdinal("PurchaseOrder"));
                        settlement.TaxPercent = reader.GetDecimal(reader.GetOrdinal("PodatekProcent"));   
                        settlement.Period = reader.GetDateTime(reader.GetOrdinal("Okres"));
                    }
                }
            }

            return settlement;
        }

        public static void Update(Settlement settlement)
        {
            using (SqlConnection dbConnection = new DBConnection().Connection)
            {
                string sqlQuery = string.Format("UPDATE [RozliczenieUmowy] " +
                    "SET DoWyplaty = @doWyplaty, DataObowiazywaniaCertyfikatu = @dataObowiazywaniaCertyfikatu, Uwagi = @uwagi, DataWysylki = @dataWysylki, " +
                    "AdresEmail = @adresEmail, DataGenerowania = @dataGenerowania, KwotaFaktury = @kwotaFaktury, NumerFaktury = @numerFaktury, " +
                    "Zablokowane = @zablokowane, PurchaseOrder = @purchaseOrder, PodatekProcent = @podatekProcent, " +
                    "EdycjaUzytkownik = @edycjaUzytkownik, EdycjaData = @edycjaData " +
                    "WHERE Id = @id");

                using (SqlCommand command = new SqlCommand(sqlQuery, dbConnection))
                {
                    command.Parameters.Add("@id", SqlDbType.Int, 6).Value = settlement.Id;
                    command.Parameters.Add("@doWyplaty", SqlDbType.Decimal, 10).Value = settlement.AmountToPayOut ?? System.Data.SqlTypes.SqlDecimal.Null;
                    command.Parameters.Add("@dataObowiazywaniaCertyfikatu", SqlDbType.DateTime, 8).Value = settlement.CertificateDate ?? System.Data.SqlTypes.SqlDateTime.Null;
                    command.Parameters.Add("@uwagi", SqlDbType.VarChar, 1000).Value = settlement.Comments;
                    command.Parameters.Add("@dataWysylki", SqlDbType.DateTime, 8).Value = settlement.DispatchDate ?? System.Data.SqlTypes.SqlDateTime.Null;
                    command.Parameters.Add("@adresEmail", SqlDbType.VarChar, 256).Value = settlement.Email;
                    command.Parameters.Add("@dataGenerowania", SqlDbType.DateTime, 8).Value = settlement.GenerationDate;
                    command.Parameters.Add("@kwotaFaktury", SqlDbType.Decimal, 10).Value = settlement.InvoiceAmount ?? System.Data.SqlTypes.SqlDecimal.Null;
                    command.Parameters.Add("@numerFaktury", SqlDbType.VarChar, 256).Value = settlement.InvoiceNumber;
                    command.Parameters.Add("@zablokowane", SqlDbType.Bit, 6).Value = settlement.IsLocked;
                    command.Parameters.Add("@purchaseOrder", SqlDbType.VarChar, 256).Value = settlement.PurchaseOrder;
                    command.Parameters.Add("@podatekProcent", SqlDbType.Decimal, 10).Value = settlement.TaxPercent;

                    command.Parameters.Add("@edycjaUzytkownik", SqlDbType.Int, 6).Value = AppUser.Instance.UserId;
                    command.Parameters.Add("@edycjaData", SqlDbType.DateTime, 8).Value = DateTime.Now;

                    command.ExecuteNonQuery();
                }
            }
        }

        public static void RecalculateSettlements()
        {
            using (SqlConnection dbConnection = new DBConnection().Connection)
            {
                string sqlQuery = string.Format("EXEC [dbo].[DodajRozliczenia] ");

                using (SqlCommand command = new SqlCommand(sqlQuery, dbConnection))
                {
                    command.ExecuteNonQuery();
                }
            }
        }
    }
}
