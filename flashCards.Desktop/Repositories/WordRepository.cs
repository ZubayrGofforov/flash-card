using flashCards.Desktop.Constans;
using flashCards.Desktop.Interfaces.Repositories;
using flashCards.Desktop.Models;
using Microsoft.VisualBasic.ApplicationServices;
using Npgsql;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace flashCards.Desktop.Repositories
{
    public class WordRepository : IWordRepository
    {
        private readonly NpgsqlConnection _connection = new NpgsqlConnection(DbConstans.DB_CONNECTION_STRING); 
        public async Task<bool> CreateAsync(Word entity)
        {
            try
            {
                await _connection.OpenAsync();
                string quary = "INSERT INTO words(word, translate_word, title_id) " +
                               "VALUES (@word, @translate_word, @title_id);";
                NpgsqlCommand command = new NpgsqlCommand(quary, _connection)
                {
                    Parameters =
                    {
                        new NpgsqlParameter ("word", entity.Word_),
                        new NpgsqlParameter ("translate_word", entity.TranslateWord),
                        new NpgsqlParameter ("title_id", entity.TitleId)
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
                string quary = $"DELETE FROM words WHERE id = {id}; ";
                NpgsqlCommand command = new NpgsqlCommand(quary, _connection);

                int result = await command.ExecuteNonQueryAsync();

                if (result == 0) return false;
                else return true;

            }
            catch { return false; }
            finally { await _connection.CloseAsync(); }
        }

        public async Task<Word> FindByIdAsync(long id)
        {
            try
            {
                await _connection.OpenAsync();
                string quary = $"SELECT * FROM words WHERE id = {id}; ";
                NpgsqlCommand command = new NpgsqlCommand(quary, _connection);
                var reader = await command.ExecuteReaderAsync();

                if (await reader.ReadAsync())
                {
                    return new Word()
                    {
                        Id = reader.GetInt32(0),
                        Word_ = reader.GetString(1),
                        TranslateWord = reader.GetString(2),
                        TitleId = reader.GetInt64(3),
                        CreatedAt = reader.GetDateTime(4)
                    };
                }
                else return null;
            }
            catch { return null; }
            finally { await _connection.CloseAsync(); }
        }

        public async Task<IList<Word>> GetAllAsync(int skip, int take)
        {
            try
            {
                var tasks = new List<Word>();
                await _connection.OpenAsync();
                string quary = $"SELECT * FROM words OFFSET {skip} LIMIT {take}; ";
                NpgsqlCommand command = new NpgsqlCommand(quary, _connection);
                var reader = await command.ExecuteReaderAsync();
                while (await reader.ReadAsync())
                {
                    var task = new Word()
                    {
                        Id = reader.GetInt32(0),
                        Word_ = reader.GetString(1),
                        TranslateWord = reader.GetString(2),
                        TitleId = reader.GetInt64(3),
                        CreatedAt = reader.GetDateTime(4)
                    };
                    
                    tasks.Add(task);
                }

                return tasks;
            }
            catch { return new List<Word>(); }
            finally { await _connection.CloseAsync(); }
        }

        public async Task<IList<Word>> GetAllAsync()
        {
            try
            {
                var tasks = new List<Word>();
                await _connection.OpenAsync();
                string quary = $"SELECT * FROM words; ";
                NpgsqlCommand command = new NpgsqlCommand(quary, _connection);
                var reader = await command.ExecuteReaderAsync();
                while (await reader.ReadAsync())
                {
                    var task = new Word()
                    {
                        Id = reader.GetInt32(0),
                        Word_ = reader.GetString(1),
                        TranslateWord = reader.GetString(2),
                        TitleId = reader.GetInt64(3),
                        CreatedAt = reader.GetDateTime(4)
                    };

                    tasks.Add(task);
                }

                return tasks;
            }
            catch { return new List<Word>(); }
            finally { await _connection.CloseAsync(); }
        }

        public async Task<IList<Word>> GetAllByWordIdAsync(long titleId, int skip, int take)
        {
            try
            {
                var words = new List<Word>();
                await _connection.OpenAsync();
                string quary = $"SELECT * FROM words WHERE user_id = {titleId} " +
                               $"OFFSET {skip} LIMIT {take}; ";
                NpgsqlCommand command = new NpgsqlCommand(quary, _connection);
                var reader = await command.ExecuteReaderAsync();
                while (await reader.ReadAsync())
                {
                    var word = new Word()
                    {
                        Id = reader.GetInt32(0),
                        Word_ = reader.GetString(1),
                        TranslateWord = reader.GetString(2),
                        TitleId = reader.GetInt64(3),
                        CreatedAt = reader.GetDateTime(4)
                    };
                    words.Add(word);
                }

                return words;
            }
            catch { return new List<Word>(); }
            finally { await _connection.CloseAsync(); }
        }

        public async Task<bool> UpdateAsync(long id, Word entity)
        {
            try
            {
                await _connection.OpenAsync();
                string quary = "UPDATE words SET word = @word, translate_word = @translate_word, title_id = @title_id " +
                              $"WHERE id = {id}; ";

                NpgsqlCommand command = new NpgsqlCommand(quary, _connection)
                {
                    Parameters =
                    {
                        new NpgsqlParameter ("word", entity.Word_),
                        new NpgsqlParameter ("translate_word", entity.TranslateWord),
                        new NpgsqlParameter ("title_id", entity.TitleId)
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
