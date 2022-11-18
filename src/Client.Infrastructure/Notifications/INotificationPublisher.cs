using FSH.WebApi.Shared.Notifications;

namespace Stocker.Web.Client.Infrastructure.Notifications;

public interface INotificationPublisher
{
    Task PublishAsync(INotificationMessage notification);
}