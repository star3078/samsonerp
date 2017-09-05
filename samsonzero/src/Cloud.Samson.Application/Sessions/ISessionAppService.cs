using System.Threading.Tasks;
using Abp.Application.Services;
using Cloud.Samson.Sessions.Dto;

namespace Cloud.Samson.Sessions
{
    public interface ISessionAppService : IApplicationService
    {
        Task<GetCurrentLoginInformationsOutput> GetCurrentLoginInformations();
    }
}
