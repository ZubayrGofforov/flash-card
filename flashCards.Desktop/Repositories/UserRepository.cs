using flashCards.Desktop.Constans;
using flashCards.Desktop.Interfaces.Repositories;
using flashCards.Desktop.Models;
using Npgsql;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace flashCards.Desktop.Repositories
{
    public class UserRepository : IUserRepository
    {
        private readonly NpgsqlConnection _connection = new NpgsqlConnection(DbConstans.DB_CONNECTION_STRING);
        public async Task<bool> CreateAsync(User entity)
        {
            try
            {
                await _connection.OpenAsync();
                string quary = "INSERT INTO users(full_name, username, password_hash, salt, birth_date) " +
                               "VALUES (@full_name, @username, @password_hash, @salt, @birth_date); ";
                NpgsqlCommand command = new NpgsqlCommand(quary, _connection)
                {
                    Parameters =
                    {
                        new NpgsqlParameter ("full_name", entity.FullName),
                        new NpgsqlParameter ("username", entity.Username),
                        new NpgsqlParameter ("password_hash", entity.PasswordHash),
                        new NpgsqlParameter ("salt", entity.Salt),
                        new NpgsqlParameter ("birth_date", entity.BirthDate)
                    }
                };

                int result = await command.ExecuteNonQueryAsync();

                if (result == 0) return false;
                else return true;
            }
            catch { return false; }
            finally { await _connection.CloseAsync(); }
        }

        public async Task<bool> DeleteAsync(long id)
        {
            try
            {
                await _connection.OpenAsync();
                string quary = $"DELETE FROM users WHERE id = {id}; ";
                NpgsqlCommand command = new NpgsqlCommand(quary, _connection);

                int result = await command.ExecuteNonQueryAsync();

                if (result == 0) return false;
                else return true;

            }
            catch { return false; }
            finally { await _connection.CloseAsync(); }
        }

        public async Task<User> FindByIdAsync(long id)
        {
            try
            {
                await _connection.OpenAsync();
                string quary = $"SELECT * FROM users WHERE id = {id};";
                NpgsqlCommand command = new NpgsqlCommand(quary, _connection);
                var reader = await command.ExecuteReaderAsync();

                if (await reader.ReadAsync())
                {
                    return new User()
                    {
                        Id = reader.GetInt64(0),
                        FullName = reader.GetString(1),
                        Username = reader.GetString(2),
                        PasswordHash = reader.GetString(3),
                        Salt = reader.GetString(4),
                        BirthDate = reader.GetDateTime(5)
                    };
                }
                else return null;
            }
            catch { return null; }
            finally { await _connection.CloseAsync(); }
        }

        public async Task<User> FindByUsername(string username)
        {
            try
            {
                await _connection.OpenAsync();
                string quary = "SELECT * FROM users WHERE username = @username;";
                NpgsqlCommand command = new NpgsqlCommand(quary, _connection)
                {
                    Parameters =
                    {
                        new NpgsqlParameter ("username", username)
                    }
                };
                var reader = await command.ExecuteReaderAsync();

                if (await reader.ReadAsync())
                {
                    return new User()
                    {
                        Id = reader.GetInt64(0),
                        FullName = reader.GetString(1),
                        Username = reader.GetString(2),
                        PasswordHash = reader.GetString(3),
                        Salt = reader.GetString(4),
                        BirthDate = reader.GetDateTime(5)
                    };
                }
                else return null;
            }
            catch { return null; }
            finally { await _connection.CloseAsync(); }
        }

        public async Task<IList<User>> GetAllAsync(int skip, int take)
        {
            try
            {
                var users = new List<User>();
                await _connection.OpenAsync();
                string quary = $"SELECT * FROM users ORDER BY full_name OFFSET {skip} LIMIT {take}; ";
                NpgsqlCommand command = new NpgsqlCommand(quary, _connection);
                var reader = await command.ExecuteReaderAsync();
                while (await reader.ReadAsync())
                {
                    var user = new User()
                    {
                        Id = reader.GetInt64(0),
                        FullName = reader.GetString(1),
                        Username = reader.GetString(2),
                        PasswordHash = reader.GetString(3),
                        Salt = reader.GetString(4),
                        BirthDate = reader.GetDateTime(5)
                    };
                    users.Add(user);
                }

                return users;
            }
            catch { return new List<User>(); }
            finally { await _connection.CloseAsync(); }
        }

        public async Task<bool> UpdateAsync(long id, User entity)
        {
            try
            {
                await _connection.OpenAsync();
                string quary = "UPDATE users SET " +
                    "full_name = @full_name, username = @username, " +
                    "password_hash = @password_hash, salt = @salt, birth_date = @birth_date " +
                    $"WHERE id = {id}; ";

                NpgsqlCommand command = new NpgsqlCommand(quary, _connection)
                {
                    Parameters =
                    {
                        new NpgsqlParameter ("full_name", entity.FullName),
                        new NpgsqlParameter ("username", entity.Username),
                        new NpgsqlParameter ("password_hash", entity.PasswordHash),
                        new NpgsqlParameter ("salt", entity.Salt),
                        new NpgsqlParameter ("birth_date", entity.BirthDate)
                    }
                };

                int result = await command.ExecuteNonQueryAsync();

                if (result == 0) return false;
                else return true;
            }
            catch { return false; }
            finally { await _connection.CloseAsync(); }
        }
    }
}
