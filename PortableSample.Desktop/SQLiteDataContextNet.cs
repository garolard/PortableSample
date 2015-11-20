using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PortableSample.DataAccess;
using SQLite.Net;
using SQLite.Net.Interop;
using SQLite.Net.Platform.Generic;

namespace PortableSample.Desktop
{
    public class SQLiteDataContextNet : SqLiteDataContext
    {
        protected override ISQLitePlatform SQLitePlatform => new SQLitePlatformGeneric();

        protected override SQLiteConnectionString ConnectionString => new SQLiteConnectionString(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "\\" + DatabaseName, storeDateTimeAsTicks: false);
    }
}
