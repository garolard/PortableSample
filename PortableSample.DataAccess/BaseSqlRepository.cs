using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using SQLite.Net.Async;

namespace PortableSample.DataAccess
{
    public class BaseSqlRepository<T> : IRepository<T>
        where T: class, new()
    {
        protected SQLiteAsyncConnection Conn { get; set; }

        public BaseSqlRepository(ISqLiteDataContext dataContext)
        {
            Conn = dataContext.SqLiteAsyncConnection;
        }

        public Task InitializeAsync()
        {
            return Conn.CreateTableAsync<T>();
        }

        public async Task<T> SaveAsync(T value)
        {
            await Conn.InsertAsync(value);
            return value;
        }

        public Task<List<T>> FindAsync(Expression<Func<T, bool>> predicate)
        {
            return Conn.Table<T>().Where(predicate).ToListAsync();
        }

        public Task<int> DeleteAsync(T value)
        {
            return Conn.DeleteAsync(value);
        }
    }
}
