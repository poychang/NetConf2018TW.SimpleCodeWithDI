using System.Collections.Generic;

namespace AspNetCoreWebApp.Services.SessionInfo
{
    public interface IDataService
    {
        IEnumerable<Models.SessionInfo> FetchData();
    }
}
