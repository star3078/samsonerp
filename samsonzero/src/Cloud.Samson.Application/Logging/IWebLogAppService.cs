using Abp.Application.Services;
using Cloud.Samson.Dto;
using Cloud.Samson.Logging.Dto;

namespace Cloud.Samson.Logging
{
    public interface IWebLogAppService : IApplicationService
    {
        GetLatestWebLogsOutput GetLatestWebLogs();

        FileDto DownloadWebLogs();
    }
}
