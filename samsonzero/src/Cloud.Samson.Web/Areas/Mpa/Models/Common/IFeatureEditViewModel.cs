using System.Collections.Generic;
using Abp.Application.Services.Dto;
using Cloud.Samson.Editions.Dto;

namespace Cloud.Samson.Web.Areas.Mpa.Models.Common
{
    public interface IFeatureEditViewModel
    {
        List<NameValueDto> FeatureValues { get; set; }

        List<FlatFeatureDto> Features { get; set; }
    }
}