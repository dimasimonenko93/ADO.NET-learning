using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Data.SqlClient;
using System.Data.Linq;

namespace SQLiteApp
{
    public class Connection : DataContext
    {
        public string connectionString { get; }
        public Connection(string connection) : base(connection)
        {
            connectionString = ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString;
        }
    }
}
