using System.Threading.Tasks;
using Abp.Application.Services;
using Abp.Application.Services.Dto;
using SamsonErp.Roles.Dto;
using SamsonErp.Users.Dto;

namespace SamsonErp.Users
{
    public interface IUserAppService : IAsyncCrudAppService<UserDto, long, PagedResultRequestDto, CreateUserDto, UpdateUserDto>
    {
        Task<ListResultDto<RoleDto>> GetRoles();
    }
}