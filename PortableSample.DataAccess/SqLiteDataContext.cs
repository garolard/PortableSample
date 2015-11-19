using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SQLite.Net;
using SQLite.Net.Async;
using SQLite.Net.Interop;

namespace PortableSample.DataAccess
{
    public abstract class SqLiteDataContext : ISqLiteDataContext
    {
        protected string DatabaseName => "test.db";

        protected abstract ISQLitePlatform SQLitePlatform { get; }

        protected abstract SQLiteConnectionString ConnectionString { get; }

        public SQLiteAsyncConnection SqLiteAsyncConnection { get; private set; }

        protected SqLiteDataContext()
        {
            SqLiteAsyncConnection = new SQLiteAsyncConnection(
                () => new SQLiteConnectionWithLock(SQLitePlatform, ConnectionString));
        }
    }
}
