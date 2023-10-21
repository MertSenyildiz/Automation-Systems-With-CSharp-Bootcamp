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
    public class PostgresRoomPriceDal:IRoomPriceDal
    {
        IDbFactory _dbFactory;
        public PostgresRoomPriceDal(IDbFactory dbFactory)
        {
            _dbFactory = dbFactory;
        }

        public async Task DeleteAsync(RoomPrice roomPrice)
        {
            var sql = @"DELETE FROM room_prices WHERE id=@ID";
            using var conn=_dbFactory.CreateDbConnection();
            await conn.ExecuteAsync(sql, new {ID=roomPrice.ID});
        }

        public async Task<IEnumerable<RoomPrice>> GetAllAsync()
        {
            var sql = @"SELECT * FROM room_prices ORDER BY start_date ASC";
            using var conn = _dbFactory.CreateDbConnection();
            return await conn.QueryAsync<RoomPrice>(sql);
        }

        public async Task<IEnumerable<RoomPricesWithDetailsDto>> GetAllWithDetailsAsync()
        {
            var sql = @"SELECT room_prices.id,start_date,end_date,price,category_name FROM room_prices 
                        LEFT JOIN categories
                        ON categories.id=category_id
                        ORDER BY start_date ASC";
            using var conn = _dbFactory.CreateDbConnection();
            return await conn.QueryAsync<RoomPricesWithDetailsDto>(sql);
        }

        public async Task<IEnumerable<RoomPrice>> GetByCategory(Guid categoryId)
        {
            var sql = @"SELECT * FROM room_prices WHERE category_id=@CategoryId ORDER BY start_date ASC";
            using var conn = _dbFactory.CreateDbConnection();
            return await conn.QueryAsync<RoomPrice>(sql, new {CategoryId=categoryId});
        }

        public async Task<IEnumerable<RoomPrice>> GetByCategoryAndOverlappingDatesAsync(Guid categoryId, DateTime start, DateTime end)
        {
            //var sql = @"SELECT * FROM room_prices 
            //            WHERE category_id=@CategoryID
            //            AND (start_date <= @StartDate AND end_date >= @StartDate)
            //            OR (start_date <= @EndDate AND end_date >= @EndDate)
            //            OR (start_date >= @StartDate AND end_date <= @EndDate)";
            var sql = @"SELECT * FROM room_prices 
                        WHERE @CategoryID IN (SELECT category_id
                                WHERE (start_date <= @StartDate AND end_date >= @StartDate)
                                OR (start_date <= @EndDate AND end_date >= @EndDate)
                                OR (start_date >= @StartDate AND end_date <= @EndDate))";
            using var conn = _dbFactory.CreateDbConnection();
            return await conn.QueryAsync<RoomPrice>(sql,new { CategoryId = categoryId, StartDate =start, EndDate =end});
        }

        public async Task<RoomPrice> GetByIdAsync(Guid id)
        {
            var sql = @"SELECT * FROM room_prices WHERE id=@ID";
            using var conn = _dbFactory.CreateDbConnection();
            return await conn.QueryFirstOrDefaultAsync<RoomPrice>(sql, new { ID = id });
        }

        public async Task<RoomPrice> GetOverlappingAsync(RoomPrice roomPrice)
        {
            var sql = @"SELECT * FROM room_prices 
                        WHERE @CategoryID IN (SELECT category_id
                                WHERE (start_date <= @StartDate AND end_date >= @StartDate)
                                OR (start_date <= @EndDate AND end_date >= @EndDate)
                                OR (start_date >= @StartDate AND end_date <= @EndDate))";
            using var conn=_dbFactory.CreateDbConnection();
            return await conn.QueryFirstOrDefaultAsync<RoomPrice>(sql,roomPrice);
        }

        public async Task InsertAsync(RoomPrice roomPrice)
        {
            var sql = @"INSERT INTO room_prices(id,start_date,end_date,price,category_id)
                        VALUES (@ID,@StartDate,@EndDate,@Price,@CategoryID)";
            using var conn = _dbFactory.CreateDbConnection();
            await conn.ExecuteAsync(sql,roomPrice);
        }

        public Task<int> OverlappingDatesCountAsync(RoomPrice roomPrice)
        {
            throw new NotImplementedException();
        }

        public async Task UpdateAsync(RoomPrice roomPrice)
        {
            var sql = @"UPDATE room_prices SET
                        start_date=@StartDate,
                        end_date=@EndDate,
                        price=@Price,
                        category_id=@CategoryID
                        WHERE id=@ID";
            using var conn = _dbFactory.CreateDbConnection();
            await conn.ExecuteAsync(sql, roomPrice);
        }
    }
}
