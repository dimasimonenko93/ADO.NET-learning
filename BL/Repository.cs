using ADO.NET.DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL
{
    public class Repository
    {
        public DataSet DataSet { get; }

        private Connection _database;
        public Repository()
        {
            _database = new Connection();
            DataSet = new DataSet();
            //DataSet = FillDataSet(_database.connectionString).Result;

            string sql = "SELECT * FROM Test";  // what if table will be have spaces in it name ?
            using (SqlConnection connection = new SqlConnection(_database.connectionString))
            {
                connection.Open();
                SqlDataAdapter adapter = new SqlDataAdapter(sql, connection);
                adapter.Fill(DataSet);
            }
        }

        private async Task<DataSet> FillDataSet(string connectionString)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string sql = "SELECT * FROM Test";
                await connection.OpenAsync();
                SqlDataAdapter adapter = new SqlDataAdapter(sql, connection);
                DataSet ds = new DataSet();
                adapter.Fill(ds);
                return ds;
            }
        }
    }
}
