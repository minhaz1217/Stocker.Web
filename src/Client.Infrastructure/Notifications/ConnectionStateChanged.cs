using FSH.WebApi.Shared.Notifications;

namespace Stocker.Web.Client.Infrastructure.Notifications;

public record ConnectionStateChanged(ConnectionState State, string? Message) : INotificationMessage;