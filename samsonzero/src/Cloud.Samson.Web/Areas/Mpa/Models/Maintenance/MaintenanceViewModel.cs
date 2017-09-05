using System.Collections.Generic;
using Cloud.Samson.Caching.Dto;

namespace Cloud.Samson.Web.Areas.Mpa.Models.Maintenance
{
    public class MaintenanceViewModel
    {
        public IReadOnlyList<CacheDto> Caches { get; set; }
    }
}