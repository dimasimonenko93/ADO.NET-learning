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

        public Repository()
        {
            DataSet = new DataSet();

            FillDataSet();

            DataSet.Tables[0].Columns[0].ReadOnly = true;
        }

        public int CreateItem()
        {
            T item = new T();
            items.Create(item);
            IModel itemID = item;
            return itemID.Id;
        }

        public void DeleteItem(int itemId)
        {
            items.Delete(itemId);
        }

        public List<object> GetAllItems()
        {
            return items.GetAll().ToList<object>();
        }
        public void SaveToXML()
        {
                DataSet.WriteXml("TestXML.xml");
        }
        public void SaveToDatabase()
        {

        }

        private void FillDataSet()
        {
            //string sql = "SELECT * FROM Test";  // what if table will be have spaces in it name ?
            //using (SqlConnection connection = new SqlConnection(_database.connectionString))
            //{
            //    connection.Open();
            //    SqlDataAdapter adapter = new SqlDataAdapter(sql, connection);
            //    adapter.Fill(DataSet);
            //}
        }
    }
}
