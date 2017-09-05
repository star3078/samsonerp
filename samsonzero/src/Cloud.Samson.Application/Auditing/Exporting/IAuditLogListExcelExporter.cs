using System.Collections.Generic;
using Cloud.Samson.Auditing.Dto;
using Cloud.Samson.Dto;

namespace Cloud.Samson.Auditing.Exporting
{
    public interface IAuditLogListExcelExporter
    {
        FileDto ExportToFile(List<AuditLogListDto> auditLogListDtos);
    }
}
