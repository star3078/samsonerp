using System.Threading.Tasks;
using Abp;
using Abp.Notifications;
using Cloud.Samson.Authorization.Users;
using Cloud.Samson.MultiTenancy;

namespace Cloud.Samson.Notifications
{
    public interface IAppNotifier
    {
        Task WelcomeToTheApplicationAsync(User user);

        Task NewUserRegisteredAsync(User user);

        Task NewTenantRegisteredAsync(Tenant tenant);

        Task SendMessageAsync(UserIdentifier user, string message, NotificationSeverity severity = NotificationSeverity.Info);
    }
}
