using Npgsql;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelBookingAutomation.Core.Factories
{
    public class PotgresDbFactory : IDbFactory
    {
        string _connectionString;
        public PotgresDbFactory(string connectionString)
        {
            _connectionString = connectionString;
        }
        public IDbConnection CreateDbConnection()
        {
            return new NpgsqlConnection(_connectionString);
        }
    }
}
