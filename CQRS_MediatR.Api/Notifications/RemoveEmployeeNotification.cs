using MediatR;

namespace CQRS_MediatR.Api.Notifications
{
    public record RemoveEmployeeNotification(int id) : INotification;
}
