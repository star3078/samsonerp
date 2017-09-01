using Abp.Application.Services.Dto;
using Abp.AutoMapper;
using SamsonErp.Authorization.Users;
using SamsonErp.Users;

namespace SamsonErp.Sessions.Dto
{
    [AutoMapFrom(typeof(User))]
    public class UserLoginInfoDto : EntityDto<long>
    {
        public string Name { get; set; }

        public string Surname { get; set; }

        public string UserName { get; set; }

        public string EmailAddress { get; set; }
    }
}
