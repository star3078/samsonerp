using System.Collections.Generic;
using Abp.Application.Services.Dto;
using Cloud.Samson.Configuration.Tenants.Dto;

namespace Cloud.Samson.Web.Areas.Mpa.Models.Settings
{
    public class SettingsViewModel
    {
        public TenantSettingsEditDto Settings { get; set; }
        
        public List<ComboboxItemDto> TimezoneItems { get; set; }
    }
}