using Abp.Notifications;
using Cloud.Samson.Dto;

namespace Cloud.Samson.Notifications.Dto
{
    public class GetUserNotificationsInput : PagedInputDto
    {
        public UserNotificationState? State { get; set; }
    }
}