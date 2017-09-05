using Cloud.Samson.Dto;

namespace Cloud.Samson.Common.Dto
{
    public class FindUsersInput : PagedAndFilteredInputDto
    {
        public int? TenantId { get; set; }
    }
}