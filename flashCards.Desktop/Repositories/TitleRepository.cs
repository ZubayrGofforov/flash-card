using flashCards.Desktop.Constans;
using flashCards.Desktop.Interfaces.Repositories;
using flashCards.Desktop.Models;
using Npgsql;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace flashCards.Desktop.Repositories
{
    public class TitleRepository : ITitleRepository
    {
        private readonly NpgsqlConnection _connection = new NpgsqlConnection(DbConstans.DB_CONNECTION_STRING);
        public async Task<bool> CreateAsync(Title entity)
        {
            try
            {
                await _connection.OpenAsync();
                string quary = "INSERT INTO titles(words_title, user_id, description) " +
                               "VALUES (@words_title, @user_id, @description);";
                NpgsqlCommand command = new NpgsqlCommand(quary, _connection)
                {
                    Parameters =
                    {
                        new NpgsqlParameter ("words_title", entity.WordsTitle),
                        new NpgsqlParameter ("user_id", entity.UserId),
                        new NpgsqlParameter ("description", entity.Description)
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
                string quary = $"DELETE FROM titles WHERE id = {id}; ";
                NpgsqlCommand command = new NpgsqlCommand(quary, _connection);

                int result = await command.ExecuteNonQueryAsync();

                if (result == 0) return false;
                else return true;

            }
            catch { return false; }
            finally { await _connection.CloseAsync(); }
        }

        public async Task<Title> FindByIdAsync(long id)
        {
            try
            {
                await _connection.OpenAsync();
                string quary = $"SELECT * FROM titles WHERE id = {id}; ";
                NpgsqlCommand command = new NpgsqlCommand(quary, _connection);
                var reader = await command.ExecuteReaderAsync();

                if (await reader.ReadAsync())
                {
                    return new Title()
                    {
                        Id = reader.GetInt32(0),
                        WordsTitle = reader.GetString(1),
                        UserId = reader.GetInt64(2)
                    };
                }
                else return null;
            }
            catch { return null; }
            finally { await _connection.CloseAsync(); }
        }

        public async Task<IList<Title>> GetAllByUserIdAsync(long userId, int skip, int take)
        {
            try
            {
                var tasks = new List<Title>();
                await _connection.OpenAsync();
                string quary = $"SELECT * FROM titles WHERE user_id = {userId} " +
                               $"OFFSET {skip} LIMIT {take}; ";
                NpgsqlCommand command = new NpgsqlCommand(quary, _connection);
                var reader = await command.ExecuteReaderAsync();
                while (await reader.ReadAsync())
                {
                    var task = new Title()
                    {
                        Id = reader.GetInt32(0),
                        WordsTitle = reader.GetString(1),
                        UserId = reader.GetInt64(2)
                    };
                    tasks.Add(task);
                }

                return tasks;
            }
            catch { return new List<Title>(); }
            finally { await _connection.CloseAsync(); }
        }

        public async Task<IList<Title>> GetAllAsync(int skip, int take)
        {
            try
            {
                var tasks = new List<Title>();
                await _connection.OpenAsync();
                string quary = $"SELECT * FROM titles OFFSET {skip} LIMIT {take}; ";
                NpgsqlCommand command = new NpgsqlCommand(quary, _connection);
                var reader = await command.ExecuteReaderAsync();
                while (await reader.ReadAsync())
                {
                    var task = new Title()
                    {
                        Id = reader.GetInt32(0),
                        WordsTitle = reader.GetString(1),
                        UserId = reader.GetInt64(2)
                    };
                    tasks.Add(task);
                }

                return tasks;
            }
            catch { return new List<Title>(); }
            finally { await _connection.CloseAsync(); }
        }

        public async Task<bool> UpdateAsync(long id, Title entity)
        {
            try
            {
                await _connection.OpenAsync();
                string quary = "UPDATE titles SET words_title = @words_title, user_id = @user_id " +
                              $"WHERE id = {id}; ";

                NpgsqlCommand command = new NpgsqlCommand(quary, _connection)
                {
                    Parameters =
                    {
                        new NpgsqlParameter ("words_title", entity.WordsTitle),
                        new NpgsqlParameter ("user_id", entity.UserId)
                    }
                };

                int result = await command.ExecuteNonQueryAsync();

                if (result == 0) return false;
                else return true;

            }
            catch { return false; }
            finally { await _connection.CloseAsync(); }
        }

        public async Task<IList<Title>> GetAllAsync()
        {
            try
            {
                var tasks = new List<Title>();
                await _connection.OpenAsync();
                string quary = $"SELECT * FROM titles; ";
                NpgsqlCommand command = new NpgsqlCommand(quary, _connection);
                var reader = await command.ExecuteReaderAsync();
                while (await reader.ReadAsync())
                {
                    var task = new Title()
                    {
                        Id = reader.GetInt32(0),
                        WordsTitle = reader.GetString(1),
                        UserId = reader.GetInt64(2)
                    };
                    tasks.Add(task);
                }

                return tasks;
            }
            catch { return new List<Title>(); }
            finally { await _connection.CloseAsync(); }
        }
    }
}
