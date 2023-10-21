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
    public class PostgresRoomDal:IRoomDal
    {
        IDbFactory _dbFactory;
        public PostgresRoomDal(IDbFactory dbFactory)
        {
            _dbFactory = dbFactory;
        }

        public async Task DeleteAsync(Room room)
        {
            var sql = @"DELETE FROM rooms WHERE id=@ID";
            using var conn=_dbFactory.CreateDbConnection();
            await conn.ExecuteAsync(sql,new {ID=room.ID});
        }

        public async Task<IEnumerable<Room>> GetAllAsync()
        {
            var sql = @"SELECT * FROM rooms";
            using var conn = _dbFactory.CreateDbConnection();
            return await conn.QueryAsync<Room>(sql);
        }

        public async Task<IEnumerable<RoomWithDetailsDto>> GetAllAvailableAsync(DateTime startDate, DateTime endDate)
        {
            var sql = @"SELECT rooms.id,room_no,floor,unique_room_no,category_name FROM rooms
                        LEFT JOIN categories
                        ON categories.id=category_id
                        WHERE rooms.id NOT IN (SELECT room_id FROM bookings 
                              WHERE ((check_in_date <= @StartDate AND check_out_date >= @StartDate)
                              OR (check_in_date <= @EndDate AND check_out_date >= @EndDate)
                              OR (check_in_date >= @StartDate AND check_out_date <= @EndDate)))
                        ORDER BY floor,room_no";
            using var conn = _dbFactory.CreateDbConnection();
            return await conn.QueryAsync<RoomWithDetailsDto>(sql,new {StartDate=startDate,EndDate=endDate});
        }

        public async Task<IEnumerable<RoomWithDetailsDto>> GetAllBookedAsync(DateTime startDate, DateTime endDate)
        {
            var sql = @"SELECT rooms.id,room_no,floor,unique_room_no,category_name FROM rooms
                        LEFT JOIN categories
                        ON categories.id=category_id
                        WHERE rooms.id IN (SELECT room_id FROM bookings 
                              WHERE ((check_in_date <= @StartDate AND check_out_date >= @StartDate)
                              OR (check_in_date <= @EndDate AND check_out_date >= @EndDate)
                              OR (check_in_date >= @StartDate AND check_out_date <= @EndDate)))
                        ORDER BY floor,room_no";
            using var conn = _dbFactory.CreateDbConnection();
            return await conn.QueryAsync<RoomWithDetailsDto>(sql, new { StartDate = startDate, EndDate = endDate });
        }

        public async Task<IEnumerable<RoomWithDetailsDto>> GetAllWithDetailsAsync()
        {
            var sql = @"SELECT rooms.id,room_no,floor,unique_room_no,category_name FROM rooms
                        LEFT JOIN categories
                        ON categories.id=category_id";
            using var conn= _dbFactory.CreateDbConnection();
            return await conn.QueryAsync<RoomWithDetailsDto>(sql);
        }

        public async Task<Room> GetByIdAsync(Guid id)
        {
            var sql = @"SELECT * FROM rooms WHERE id=@ID";
            using var conn = _dbFactory.CreateDbConnection();
            return await conn.QueryFirstOrDefaultAsync<Room>(sql, new { ID = id });
        }

        public async Task<Room> GetByUniqueNoAsync(string uniqueRoomNo)
        {
            var sql = @"SELECT * FROM rooms WHERE unique_room_no=@UniqueRoomNo";
            using var conn = _dbFactory.CreateDbConnection();
            return await conn.QueryFirstOrDefaultAsync<Room>(sql, new { UniqueRoomNo = uniqueRoomNo });
        }

        public async Task InsertAsync(Room room)
        {
            var sql = @"INSERT INTO rooms(id,floor,room_no,unique_room_no,category_id)
                        VALUES (@ID,@Floor,@RoomNo,@UniqueRoomNo,@CategoryID)";
            using var conn = _dbFactory.CreateDbConnection();
            await conn.ExecuteAsync(sql, room);
        }

        public async Task UpdateAsync(Room room)
        {
            var sql = @"UPDATE rooms SET
                        floor=@Floor,
                        room_no=@RoomNo,
                        unique_room_no=@UniqueRoomNo,
                        category_id=@CategoryID
                        WHERE id=@ID";
            using var conn = _dbFactory.CreateDbConnection();
            await conn.ExecuteAsync(sql, room);
        }
    }
}
