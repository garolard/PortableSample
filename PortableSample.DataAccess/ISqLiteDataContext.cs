using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SQLite.Net.Async;

namespace PortableSample.DataAccess
{
    public interface ISqLiteDataContext
    {
        SQLiteAsyncConnection SqLiteAsyncConnection { get; }
    }
}
