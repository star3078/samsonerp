using System.ComponentModel.DataAnnotations;
using Abp.Application.Services.Dto;
using Cloud.Samson.Authorization.Users;

namespace Cloud.Samson.Configuration.Host.Dto
{
    public class SendTestEmailInput
    {
        [Required]
        [MaxLength(User.MaxEmailAddressLength)]
        public string EmailAddress { get; set; }
    }
}