using Dapper;
using HotelBookingAutomation.Core.Factories;
using HotelBookingAutomation.DataAcess.Abstract;
using HotelBookingAutomation.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelBookingAutomation.DataAcess.Concrete.PostgreSql
{
    public class PostgresRoleDal:IRoleDal
    {
        IDbFactory _dbFactory;
        public PostgresRoleDal(IDbFactory dbFactory)
        {
            _dbFactory = dbFactory;
        }

        public async Task DeleteAsync(Role role)
        {
            string sql = @"DELETE FROM roles WHERE id=@ID";
            using var conn = _dbFactory.CreateDbConnection();
            await conn.ExecuteAsync(sql,role);
        }

        public async Task<IEnumerable<Role>> GetAllAsync()
        {
            var sql = "SELECT * FROM roles";
            using var conn = _dbFactory.CreateDbConnection();
            return await conn.QueryAsync<Role>(sql);
        }

        public async Task InsertAsync(Role role)
        {
            string sql = @"INSERT INTO roles(id,role_name) VALUES (@ID,@RoleName)";
            using var conn = _dbFactory.CreateDbConnection();
            await conn.ExecuteAsync(sql,role);
        }

        public async Task UpdateAsync(Role role)
        {
            string sql = @"UPDATE roles SET role_name=@RoleName WHERE id=@ID";
            using var conn = _dbFactory.CreateDbConnection();
            await conn.ExecuteAsync(sql, role);
        }
    }
}
