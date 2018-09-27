using System.Collections.Generic;
using Dapper;
using Microsoft.Data.Sqlite;

namespace AspNetCoreWebApp.Services.SessionInfo
{
    public class DbService : IDataService
    {
        public IEnumerable<Models.SessionInfo> FetchData()
        {
            var connectionStringBuilder = new SqliteConnectionStringBuilder { DataSource = "Database/database.db" };
            using (var connection = new SqliteConnection(connectionStringBuilder.ConnectionString))
            {
                return connection.Query<Models.SessionInfo>("SELECT * FROM SessionInfo;");
            }
        }
    }
}
