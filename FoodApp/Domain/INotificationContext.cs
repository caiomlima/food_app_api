namespace Api.Domain
{
    public interface INotificationContext
    {
        void AddNotification(string message);
        void AddNotification(string message, string supportLink);
        bool HasNotifications { get; }
        IReadOnlyCollection<Notification> Notifications { get; }
    }
}
