﻿using System.Collections.Generic;
using Abp.Application.Services.Dto;

namespace Cloud.Samson.Web.Areas.Mpa.Models.Users
{
    public class UsersViewModel
    {
        public string FilterText { get; set; }

        public List<ComboboxItemDto> Permissions { get; set; }

        public List<ComboboxItemDto> Roles { get; set; }
    }
}