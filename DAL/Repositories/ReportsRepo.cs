using BLL;
using BLL.Entities;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace DAL.Repositories
{
    public class ReportsRepo
    {
        public static List<Report> GetAll()
        {
            List<Report> lstReports = new List<Report>();

            using (SqlConnection dbConnection = new DBConnection().Connection)
            {
                string sqlQuery = string.Format("SELECT * FROM [Raporty]");

                using (SqlCommand command = new SqlCommand(sqlQuery, dbConnection))
                {
                    SqlDataReader reader = command.ExecuteReader();

                    while (reader.Read())
                    {
                        lstReports.Add(new Report()
                        {
                            Id = reader.GetInt32(reader.GetOrdinal("id")),
                            Name = reader.GetString(reader.GetOrdinal("Nazwa")),
                            SqlViewName = reader.GetString(reader.GetOrdinal("Widok")),
                            SqlOrderBy = reader.GetString(reader.GetOrdinal("OrderBy"))
                        });
                    }
                }
            }

            return lstReports;
        }

        public static Report GetById(int reportId)
        {
            Report report = new Report();

            using (SqlConnection dbConnection = new DBConnection().Connection)
            {
                string sqlQuery = string.Format("SELECT * FROM [Raporty] WHERE Id = {0}", reportId);

                using (SqlCommand command = new SqlCommand(sqlQuery, dbConnection))
                {
                    SqlDataReader reader = command.ExecuteReader();

                    while (reader.Read())
                    {
                        report.Id = reportId;
                        report.Name = reader.GetString(reader.GetOrdinal("Nazwa"));
                        report.SqlViewName = reader.GetString(reader.GetOrdinal("Widok"));
                        report.SqlOrderBy = reader.GetString(reader.GetOrdinal("OrderBy"));                        
                    }
                }
            }

            return report;
        }
    }
}
