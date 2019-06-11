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
            
            //DataSet = FillDataSetAsync(_database.connectionString).Result; // dont work !!!
            FillDataSet();

            DataSet.Tables[0].Columns[0].ReadOnly = true;
        }

        public void SaveToXML()
        {
                DataSet.WriteXml("TestXML.xml");
        }
        public void SaveToDatabase()
        {
            string sql = "SELECT * FROM Test";
            using (SqlConnection connection = new SqlConnection(_database.connectionString))
            {
                connection.Open();
                SqlDataAdapter adapter = new SqlDataAdapter(sql, connection);
                SqlCommandBuilder commandBuilder = new SqlCommandBuilder(adapter);
                adapter.Update(DataSet);
                DataSet.Clear();
                adapter.Fill(DataSet);
            }
        }

        private void FillDataSet()
        {
            string sql = "SELECT * FROM Test";  // what if table will be have spaces in it name ?
            using (SqlConnection connection = new SqlConnection(_database.connectionString))
            {
                connection.Open();
                SqlDataAdapter adapter = new SqlDataAdapter(sql, connection);
                adapter.Fill(DataSet);
            }
        }
        private async Task<DataSet> FillDataSetAsync(string connectionString)
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
