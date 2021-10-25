using MediatR;

namespace CQRS_MediatR.Api.Notifications.NotificationHandlers
{
    public class SMSHandler : INotificationHandler<RemoveEmployeeNotification>
    {
        public Task Handle(RemoveEmployeeNotification notification, CancellationToken cancellationToken)
        {
            int id = notification.id;
            //send sms to employee
            return Task.CompletedTask;
        }
    }
}
