﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.Storage;
using PortableSample.DataAccess;
using SQLite.Net;
using SQLite.Net.Interop;
using SQLite.Net.Platform.WinRT;

namespace PortableSample.UAP
{
    public class SQLiteDataContextUAP : SqLiteDataContext
    {
        protected override ISQLitePlatform SQLitePlatform => new SQLitePlatformWinRT();

        protected override SQLiteConnectionString ConnectionString => new SQLiteConnectionString(Path.Combine(ApplicationData.Current.LocalFolder.Path, DatabaseName), storeDateTimeAsTicks: false);
    }
}
