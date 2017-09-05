using System.Collections.Generic;
using Abp.Application.Services.Dto;
using Cloud.Samson.Configuration.Host.Dto;

namespace Cloud.Samson.Web.Areas.Mpa.Models.HostSettings
{
    public class HostSettingsViewModel
    {
        public HostSettingsEditDto Settings { get; set; }

        public List<ComboboxItemDto> EditionItems { get; set; }

        public List<ComboboxItemDto> TimezoneItems { get; set; }
    }
}