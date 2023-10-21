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
    public class PostgresBookingDal:IBookingDal
    {
        IDbFactory _dbFactory;
        public PostgresBookingDal(IDbFactory dbFactory)
        {
            _dbFactory = dbFactory;
        }

        public async Task DeleteAsync(Booking booking)
        {
            var sql = @"DELETE FROM bookings WHERE id=@ID";
            using var conn=_dbFactory.CreateDbConnection();
            await conn.ExecuteAsync(sql,new {ID=booking.ID});
        }

        public Task<IEnumerable<Booking>> GetAllAsync()
        {
            //var sql = @"SELECT * FROM ";
            //using var conn = _dbFactory.CreateDbConnection();
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<BookingWithRoomNoDto>> GetByCustomerIdAndDatesAsync(Guid customerId, DateTime startDate, DateTime endDate)
        {
            //var sql = @"SELECT bookings.id,check_in_date,check_out_date,customer_id,room_id,total_price,unique_room_no FROM bookings
            //            LEFT JOIN rooms
            //            ON bookings.room_id=rooms.id
            //            WHERE customer_id=@CustomerID AND customer_id IN (SELECT customer_id FROM bookings
            //                WHERE (check_in_date <= @CheckInDate AND check_out_date >= @CheckInDate)
            //                OR (check_in_date <= @CheckOutDate AND check_out_date >= @CheckOutDate)
            //                OR (check_in_date >= @CheckInDate AND check_out_date <= @CheckOutDate))
            //                ORDER BY check_out_date DESC";
            var sql = @"SELECT bookings.id, check_in_date, check_out_date, customer_id, room_id, total_price, unique_room_no FROM bookings
                        LEFT JOIN rooms ON bookings.room_id = rooms.id
                        WHERE customer_id = @CustomerID
                            AND check_in_date BETWEEN @CheckInDate AND @CheckOutDate
                            AND check_out_date BETWEEN @CheckInDate AND @CheckOutDate
                        ORDER BY check_out_date DESC";
            using var conn = _dbFactory.CreateDbConnection();
            return await conn.QueryAsync<BookingWithRoomNoDto>(sql, new { CustomerID = customerId, CheckInDate = startDate, CheckOutDate = endDate });
        }

        public async Task<Booking> GetByIdAsync(Guid id)
        {
            var sql = @"SELECT * FROM bookings WHERE id=@ID";
            using var conn = _dbFactory.CreateDbConnection();
            return await conn.QueryFirstOrDefaultAsync<Booking>(sql, new {ID=id});
        }

        public Task<IEnumerable<Booking>> GetByRoomIdAsync(Guid roomId)
        {
            //var sql = @"SELECT * FROM ";
            //using var conn = _dbFactory.CreateDbConnection();
            throw new NotImplementedException();
        }

        public async Task<Booking> GetByRoomIdClosestDateAsync(Guid roomId,DateTime start,DateTime end)
        {
            var sql = @"SELECT * FROM bookings
                        WHERE room_id=@RoomID AND room_id IN (SELECT room_id FROM bookings
                            WHERE (check_in_date <= @CheckInDate AND check_out_date >= @CheckInDate)
                            OR (check_in_date <= @CheckOutDate AND check_out_date >= @CheckOutDate)
                            OR (check_in_date >= @CheckInDate AND check_out_date <= @CheckOutDate))
                            ORDER BY check_out_date DESC";
            using var conn=_dbFactory.CreateDbConnection();
            return await conn.QueryFirstOrDefaultAsync<Booking>(sql,new {RoomID=roomId, CheckInDate=start, CheckOutDate=end});
        }

        public async Task<Booking> GetOverlappingAsync(Booking booking)
        {
            var sql = @"SELECT * FROM bookings
                        WHERE @RoomID IN (SELECT room_id FROM bookings
                            WHERE (check_in_date <= @CheckInDate AND check_out_date >= @CheckInDate)
                            OR (check_in_date <= @CheckOutDate AND check_out_date >= @CheckOutDate)
                            OR (check_in_date >= @CheckInDate AND check_out_date <= @CheckOutDate))";
            using var conn = _dbFactory.CreateDbConnection();
            return await conn.QueryFirstOrDefaultAsync<Booking>(sql,booking);
        }

        public async Task InsertAsync(Booking booking)
        {
            var sql = @"INSERT INTO bookings(id,check_in_date,check_out_date,customer_id,room_id,total_price)
                        VALUES (@ID,@CheckInDate,@CheckOutDate,@CustomerID,@RoomID,@TotalPrice)";
            using var conn = _dbFactory.CreateDbConnection();
            await conn.ExecuteAsync(sql, booking);
        }

        public async Task UpdateAsync(Booking booking)
        {
            var sql = @"UPDATE bookings SET
                        check_in_date=@CheckInDate,
                        check_out_date=@CheckOutDate,
                        customer_id=@CustomerID,
                        room_id=@RoomID,
                        total_price=@TotalPrice
                        WHERE id=@ID";
            using var conn = _dbFactory.CreateDbConnection();
            var result=await conn.ExecuteAsync(sql, booking);
            result.ToString();
        }
    }
}
