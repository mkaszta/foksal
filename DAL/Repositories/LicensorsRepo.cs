using BLL;
using BLL.Entities;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace DAL.Repositories
{
    public class LicensorsRepo
    {
        public static List<Licensor> GetAll()
        {
            List<Licensor> lstLicensors = new List<Licensor>();

            using (SqlConnection dbConnection = new DBConnection().Connection)
            {
                string sqlQuery = string.Format("SELECT * FROM [Licencjodawca]");

                using (SqlCommand command = new SqlCommand(sqlQuery, dbConnection))
                {
                    SqlDataReader reader = command.ExecuteReader();

                    while (reader.Read())
                    {
                        lstLicensors.Add(new Licensor()
                        {
                            Id = reader.GetInt32(reader.GetOrdinal("id")),
                            CertificateDate = reader.IsDBNull(reader.GetOrdinal("DataObowiazywaniaCertyfikatu")) ? (DateTime?)null : reader.GetDateTime(reader.GetOrdinal("DataObowiazywaniaCertyfikatu")),
                            EditedBy = reader.GetInt32(reader.GetOrdinal("EdycjaUzytkownik")),
                            EditedDate = reader.GetDateTime(reader.GetOrdinal("EdycjaData")),
                            Email = reader.GetString(reader.GetOrdinal("AdresEmail")),
                            FirstName = reader.GetString(reader.GetOrdinal("Imie")),
                            LastName = reader.GetString(reader.GetOrdinal("Nazwisko")),
                            Name = reader.GetString(reader.GetOrdinal("Nazwa")),
                            IsNaturalPerson = reader.GetBoolean(reader.GetOrdinal("OsosbaFizyczna")),
                            TaxPercentage = reader.GetDecimal(reader.GetOrdinal("PodatekProcent")),
                            VAT = reader.IsDBNull(reader.GetOrdinal("PodatekVAT")) ? (decimal?)null : reader.GetDecimal(reader.GetOrdinal("PodatekVAT")),
                        });
                    }
                }
            }

            return lstLicensors;
        }

        public static List<Licensor> GetAllForCombo()
        {
            List<Licensor> lstLicensors = new List<Licensor>();

            using (SqlConnection dbConnection = new DBConnection().Connection)
            {
                string sqlQuery = string.Format("SELECT * FROM [vLicnecjodawcaCombo] ORDER BY licencjodawca");

                using (SqlCommand command = new SqlCommand(sqlQuery, dbConnection))
                {
                    SqlDataReader reader = command.ExecuteReader();

                    while (reader.Read())
                    {
                        lstLicensors.Add(new Licensor()
                        {
                            Id = reader.GetInt32(reader.GetOrdinal("id")),
                            Name = reader.GetString(reader.GetOrdinal("licencjodawca"))
                        });
                    }
                }
            }

            return lstLicensors;
        }

        public static Licensor GetById(int licensorId)
        {
            Licensor licensor = new Licensor();

            using (SqlConnection dbConnection = new DBConnection().Connection)
            {
                string sqlQuery = string.Format("SELECT * FROM [Licencjodawca] WHERE [Id] = {0}", licensorId);

                using (SqlCommand command = new SqlCommand(sqlQuery, dbConnection))
                {
                    SqlDataReader reader = command.ExecuteReader();

                    while (reader.Read())
                    {
                        licensor.Id = reader.GetInt32(reader.GetOrdinal("id"));
                        licensor.CertificateDate = reader.IsDBNull(reader.GetOrdinal("DataObowiazywaniaCertyfikatu")) ? (DateTime?)null : reader.GetDateTime(reader.GetOrdinal("DataObowiazywaniaCertyfikatu"));
                        licensor.EditedBy = reader.GetInt32(reader.GetOrdinal("EdycjaUzytkownik"));
                        licensor.EditedDate = reader.GetDateTime(reader.GetOrdinal("EdycjaData"));
                        licensor.Email = reader.GetString(reader.GetOrdinal("AdresEmail"));
                        licensor.FirstName = reader.GetString(reader.GetOrdinal("Imie"));
                        licensor.LastName = reader.GetString(reader.GetOrdinal("Nazwisko"));
                        licensor.Name = reader.GetString(reader.GetOrdinal("Nazwa"));
                        licensor.IsNaturalPerson = reader.GetBoolean(reader.GetOrdinal("OsosbaFizyczna"));
                        licensor.TaxPercentage = reader.GetDecimal(reader.GetOrdinal("PodatekProcent"));
                        licensor.VAT = reader.IsDBNull(reader.GetOrdinal("PodatekVAT")) ? (decimal?)null : reader.GetDecimal(reader.GetOrdinal("PodatekVAT"));
                    }
                }
            }

            return licensor;
        }

        public static void Merge(int sourceLicensorId, int targetLicensorId)
        {
            using (SqlConnection dbConnection = new DBConnection().Connection)
            {
                string sqlQuery = string.Format("UPDATE [UmowaLicencjodawca] SET LicencjodawcaId = {0}, EdycjaUzytkownik = {2} WHERE LicencjodawcaId = {1}; ", targetLicensorId, sourceLicensorId, AppUser.Instance.UserId);
                sqlQuery += string.Format("UPDATE [UmowaLicencjodawca] SET LicencjodawcaIdCareOf = {0}, EdycjaUzytkownik = {2} WHERE LicencjodawcaIdCareOf = {1}; ", targetLicensorId, sourceLicensorId, AppUser.Instance.UserId);                

                using (SqlCommand command = new SqlCommand(sqlQuery, dbConnection))
                {
                    command.ExecuteNonQuery();
                }

                sqlQuery = string.Format("DELETE FROM [Licencjodawca] WHERE id = {0}", sourceLicensorId);

                using (SqlCommand command = new SqlCommand(sqlQuery, dbConnection))
                {
                    command.ExecuteNonQuery();
                }
            }
        }
    }
}
