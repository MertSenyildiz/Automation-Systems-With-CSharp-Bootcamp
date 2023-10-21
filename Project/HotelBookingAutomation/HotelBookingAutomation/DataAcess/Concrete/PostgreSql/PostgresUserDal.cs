using Dapper;
using HotelBookingAutomation.Core.Factories;
using HotelBookingAutomation.DataAcess.Abstract;
using HotelBookingAutomation.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace HotelBookingAutomation.DataAcess.Concrete.PostgreSql
{
    public class PostgresUserDal : IUserDal
    {
        IDbFactory _dbFactory;
        public PostgresUserDal(IDbFactory dbFactory)
        {
            _dbFactory = dbFactory;
        }

        public async Task DeleteAsync(User user)
        {
            string sql = "DELETE FROM users WHERE id=@ID";
            using var conn=_dbFactory.CreateDbConnection();
            await conn.ExecuteAsync(sql,new {ID=user.ID});
        }

        public async Task<List<User>> GetAllAsync()
        {
            string sql = "SELECT * FROM users";
            using var conn = _dbFactory.CreateDbConnection();
            IEnumerable<User> users;
            users=await conn.QueryAsync<User>(sql);
            return users?.ToList();
        }

        public async Task<IEnumerable<UserWithAllDetailsDto>> GetAllWithDetailsAsync()
        {
            string sql = @"SELECT 
                        username,first_name,last_name,email,phone,address,roles.role_name 
                        FROM users
                        LEFT JOIN roles
                        ON users.role_id=roles.id
                        WHERE role_name != 'Manager'";
            using var conn=_dbFactory.CreateDbConnection();
            return await conn.QueryAsync<UserWithAllDetailsDto>(sql);
        }

        public async Task<IEnumerable<UserWithAllDetailsDto>> GetAllWithDetailsBySearchTermAsync(string searchTerm)
        {
            string sql = @"SELECT 
                        username,first_name,last_name,email,phone,address,roles.role_name 
                        FROM users
                        LEFT JOIN roles
                        ON users.role_id=roles.id
                        WHERE 
                        username LIKE @search
                        OR first_name LIKE @search
                        OR last_name LIKE  @search
                        OR email LIKE @search
                        AND role_name != 'Manager'";
            using var conn = _dbFactory.CreateDbConnection();
            return await conn.QueryAsync<UserWithAllDetailsDto>(sql,new {search="%"+searchTerm+"%"});
        }

        public async Task<User> GetByIdAsync(Guid id)
        {
            string sql = @"SELECT * FROM users WHERE id = @ID";
            using var conn = _dbFactory.CreateDbConnection();
            return await conn.QuerySingleAsync<User>(sql, new { ID = id });
        }

        public async Task<User> GetByUsernameAsync(string username)
        {
            string sql = @"SELECT * FROM users WHERE username = @Username";
            using var conn= _dbFactory.CreateDbConnection();
            return await conn.QueryFirstOrDefaultAsync<User>(sql,new { Username=username });
        }

        public async Task InsertAsync(User user)
        {
            string sql = @"INSERT INTO users(id,first_name,last_name,email,username,phone,address,role_id,password,password_salt) " +
                "VALUES (@ID,@FirstName,@LastName,@Email,@Username,@Phone,@Address,@RoleID,@Password,@PasswordSalt)";
            using var conn=_dbFactory.CreateDbConnection();
            await conn.ExecuteAsync(sql, user);
        }

        public async Task UpdateAsync(User user)
        {
            string sql = @"UPDATE users SET 
                         first_name=@FirstName,
                         last_name=@LastName,
                         email=@Email,
                         username=@Username,
                         phone=@Phone,
                         address=@Address,
                         role_id=@RoleID,
                         password=@Password,
                         password_salt=@PasswordSalt
                         WHERE id=@ID";
            using var conn = _dbFactory.CreateDbConnection();
            await conn.ExecuteAsync(sql, user);
        }
    }
}
