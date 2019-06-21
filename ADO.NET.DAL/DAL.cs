using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SQLiteApp
{
    public class DAL<T> where T : class, new()
    {
        private Connection _database;

        public DAL()
        {
            _database = new Connection();
        }

        public T Get(int id)
        {
            return Items.Find(id);
        }

        public List<T> GetAll()
        {
            return Items.ToList();
        }

        public void Create(T item)
        {
            Items.Add(item);
            _dataBase.SaveChanges();
        }

        public void Update(T item)
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

            //dataBase.Entry(item).State = EntityState.Modified;
            //dataBase.SaveChanges();
        }

        public void Delete(int id)
        {
            T item = Items.Find(id);
            if (item != null)
                Items.Remove(item);
            dataBase.SaveChanges();
        }
    }
}
