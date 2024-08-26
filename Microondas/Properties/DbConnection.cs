using Npgsql;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Microondas.Properties
{
    public class DbConnection : IDisposable
    {
        public NpgsqlConnection Connection { get; set; }
        public DbConnection() 
        {
            Connection = new NpgsqlConnection("Server=localhost;Port=5432;Database=microondas;User Id=postgres;Password=micro;");
            Connection.Open();
        }

        public void Dispose()
        {
            Connection.Dispose();
        }
    }
}
