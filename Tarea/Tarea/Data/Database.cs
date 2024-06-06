using SQLite;
using System;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;
using Tarea.Models;

namespace Tarea.Data
{
    public class Database
    {
        private readonly SQLiteAsyncConnection _database;

        public Database(string dbPath)
        {
            _database = new SQLiteAsyncConnection(dbPath);
            _database.CreateTableAsync<Operacion>().Wait();
        }

        public Task<List<Operacion>> GetOperacionesAsync()
        {
            return _database.Table<Operacion>().ToListAsync();
        }

        public Task<int> SaveOperacionAsync(Operacion operacion)
        {
            return _database.InsertAsync(operacion);
        }

        public Task<int> DeleteOperacionAsync(Operacion operacion)
        {
            return _database.DeleteAsync(operacion);
        }
    }
}
