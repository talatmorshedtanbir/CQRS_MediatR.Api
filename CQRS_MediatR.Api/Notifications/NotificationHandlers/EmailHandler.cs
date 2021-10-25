using MediatR;

namespace CQRS_MediatR.Api.Notifications.NotificationHandlers
{
    public class EmailHandler : INotificationHandler<RemoveEmployeeNotification>
    {
        public Task Handle(RemoveEmployeeNotification notification, CancellationToken cancellationToken)
        {
            int id = notification.id;
            // send email to employee
            return Task.CompletedTask;
        }
    }
}
