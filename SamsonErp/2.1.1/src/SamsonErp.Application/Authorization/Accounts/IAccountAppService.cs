using System.Threading.Tasks;
using Abp.Application.Services;
using SamsonErp.Authorization.Accounts.Dto;

namespace SamsonErp.Authorization.Accounts
{
    public interface IAccountAppService : IApplicationService
    {
        Task<IsTenantAvailableOutput> IsTenantAvailable(IsTenantAvailableInput input);

        Task<RegisterOutput> Register(RegisterInput input);
    }
}
