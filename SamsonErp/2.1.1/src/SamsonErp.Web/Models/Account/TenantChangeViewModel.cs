using Abp.AutoMapper;
using SamsonErp.Sessions.Dto;

namespace SamsonErp.Web.Models.Account
{
    [AutoMapFrom(typeof(GetCurrentLoginInformationsOutput))]
    public class TenantChangeViewModel
    {
        public TenantLoginInfoDto Tenant { get; set; }
    }
}