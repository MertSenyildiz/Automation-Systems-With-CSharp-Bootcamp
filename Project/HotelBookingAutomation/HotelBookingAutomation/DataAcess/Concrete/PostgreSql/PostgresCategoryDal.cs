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
    public class PostgresCategoryDal:ICategoryDal
    {
        IDbFactory _dbFactory;
        public PostgresCategoryDal(IDbFactory dbFactory)
        {
            _dbFactory = dbFactory;
        }

        public async Task DeleteAsync(Category category)
        {
            var sql = @"DELETE FROM categories WHERE id=@ID";
            using var conn=_dbFactory.CreateDbConnection();
            await conn.ExecuteAsync(sql,new {ID=category.ID});
        }

        public async Task<IEnumerable<Category>> GetAllAsync()
        {
            var sql = @"SELECT * FROM categories";
            using var conn = _dbFactory.CreateDbConnection();
            return await conn.QueryAsync<Category>(sql);
        }

        public async Task<Category> GetByIdAsync(Guid id)
        {
            var sql = @"SELECT * FROM categories WHERE id=@ID";
            using var conn = _dbFactory.CreateDbConnection();
            return await conn.QueryFirstOrDefaultAsync<Category>(sql,new {ID=id});
        }

        public async Task InsertAsync(Category category)
        {
            var sql = @"INSERT INTO categories(id,category_name,base_price)
                        VALUES(@ID,@CategoryName,@BasePrice)";
            using var conn= _dbFactory.CreateDbConnection();
            await conn.ExecuteAsync(sql,category);
        }

        public async Task UpdateAsync(Category category)
        {
            var sql = @"UPDATE categories
                        SET category_name=@CategoryName,
                        base_price=@BasePrice
                        WHERE id=@ID";
            using var conn = _dbFactory.CreateDbConnection();
            await conn.ExecuteAsync(sql, category);
        }
    }
}
