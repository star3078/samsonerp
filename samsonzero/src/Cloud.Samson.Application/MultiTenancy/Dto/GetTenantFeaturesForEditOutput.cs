using System.Collections.Generic;
using Abp.Application.Services.Dto;
using Cloud.Samson.Editions.Dto;

namespace Cloud.Samson.MultiTenancy.Dto
{
    public class GetTenantFeaturesForEditOutput
    {
        public List<NameValueDto> FeatureValues { get; set; }

        public List<FlatFeatureDto> Features { get; set; }
    }
}