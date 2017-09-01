using Abp.Application.Services;
using Abp.Application.Services.Dto;
using SamsonErp.MultiTenancy.Dto;

namespace SamsonErp.MultiTenancy
{
    public interface ITenantAppService : IAsyncCrudAppService<TenantDto, int, PagedResultRequestDto, CreateTenantDto, TenantDto>
    {
    }
}
