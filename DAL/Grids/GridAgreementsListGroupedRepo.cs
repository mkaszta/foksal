﻿using BLL;
using Janus.Windows.GridEX;
using System.Data;
using System.Data.SqlClient;

namespace DAL.Grids
{
    public class GridAgreementsListGroupedRepo
    {
        private DBConnection dbConnection = new DBConnection();
        private DataSet dataSet = new DataSet("dataSet");
        private DataTable dataTable = new DataTable("dataTable");
        private SqlDataAdapter dataAdapter = new SqlDataAdapter();

        public void BindDataSet(GridEX grid)
        {
            dataTable.Clear();

            SqlCommand cmdSelect = new SqlCommand();
            cmdSelect.Connection = dbConnection.Connection;
            cmdSelect.CommandType = CommandType.Text;
            cmdSelect.CommandText = "SELECT * FROM [vUmowyZPozycjamiLista]";
            dataAdapter.SelectCommand = cmdSelect;

            dataAdapter.Fill(dataTable);
            grid.DataSource = dataTable;
        }
    }
}
