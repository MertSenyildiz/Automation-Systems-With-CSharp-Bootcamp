using Dapper;
using HotelBookingAutomation.Core.Factories;
using HotelBookingAutomation.DataAcess.Abstract;
using HotelBookingAutomation.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace HotelBookingAutomation.DataAcess.Concrete.PostgreSql
{
    public class PostgresCustomerDal:ICustomerDal
    {
        IDbFactory _dbFactory;

        public PostgresCustomerDal(IDbFactory dbFactory)
        {
            _dbFactory = dbFactory;
        }

        public async Task DeleteAsync(Customer customer)
        {
            var sql = @"DELETE FROM customers WHERE id=@ID";
            using var conn=_dbFactory.CreateDbConnection();
            await conn.ExecuteAsync(sql,new {ID=customer.ID});
        }

        public async Task<IEnumerable<Customer>> GetAllAsync()
        {
            var sql = @"SELECT * FROM customers";
            using var conn = _dbFactory.CreateDbConnection();
            return await conn.QueryAsync<Customer>(sql);
        }

        public async Task<IEnumerable<Customer>> GetAllBySearchTermAsync(string searchTerm)
        {
            var sql = @"SELECT * FROM customers
                        WHERE 
                        id_no LIKE @SearchTerm
                        OR country LIKE @SearchTerm
                        OR first_name LIKE @SearchTerm
                        OR last_name LIKE @SearchTerm
                        OR email LIKE @SearchTerm";
            using var conn= _dbFactory.CreateDbConnection();
            return await conn.QueryAsync<Customer>(sql, new {SearchTerm= "%" + searchTerm + "%" });
        }

        public async Task<Customer> GetByIdAsync(Guid id)
        {
            var sql = @"SELECT * FROM customers WHERE id=@ID";
            using var conn = _dbFactory.CreateDbConnection();
            return await conn.QueryFirstOrDefaultAsync<Customer>(sql,new { ID = id });
        }

        public async Task<Customer> GetByIdentificationAsync(string id)
        {
            var sql = @"SELECT * FROM customers WHERE id_no=@ID";
            using var conn = _dbFactory.CreateDbConnection();
            return await conn.QueryFirstOrDefaultAsync<Customer>(sql, new { ID = id });
        }

        public async Task InsertAsync(Customer customer)
        {
            var sql = @"INSERT INTO customers
                        (id,phone,id_no,country,zip_code,address,first_name,last_name,email)
                        VALUES (@ID,@Phone,@IDNo,@Country,@ZipCode,@Address,@FirstName,@LastName,@Email)";
            using var conn=_dbFactory.CreateDbConnection();
            await conn.ExecuteAsync(sql, customer);
        }

        public async Task UpdateAsync(Customer customer)
        {
            var sql = @"UPDATE customers SET
                        phone=@Phone,
                        id_no=@IDNo,
                        country=@Country,
                        zip_code=@ZipCode,
                        address=@Address,
                        first_name=@FirstName,
                        last_name=@LastName,
                        email=@Email
                        WHERE id=@ID";
            using var conn=_dbFactory.CreateDbConnection();
            await conn.ExecuteAsync(sql, customer);
        }
    }
}
