using System.Collections.Generic;
using Cloud.Samson.Authorization.Users.Dto;
using Cloud.Samson.Dto;

namespace Cloud.Samson.Authorization.Users.Exporting
{
    public interface IUserListExcelExporter
    {
        FileDto ExportToFile(List<UserListDto> userListDtos);
    }
}