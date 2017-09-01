using System.Threading.Tasks;
using Abp.Application.Services;
using SamsonErp.Sessions.Dto;

namespace SamsonErp.Sessions
{
    public interface ISessionAppService : IApplicationService
    {
        Task<GetCurrentLoginInformationsOutput> GetCurrentLoginInformations();
    }
}
