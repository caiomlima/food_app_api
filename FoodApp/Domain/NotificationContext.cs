using Microsoft.Extensions.Localization;

namespace Api.Domain
{
    public class NotificationContext : INotificationContext
    {
        private readonly List<Notification> _notifications;
        //private readonly IStringLocalizer<SharedResource> _localizer;

        public IReadOnlyCollection<Notification> Notifications => _notifications.AsReadOnly();
        public bool HasNotifications => _notifications.Any();

        //public NotificationContext(IStringLocalizer<SharedResource> localizer)
        //{
        //    _notifications = new List<Notification>();
        //    _localizer = localizer;
        //}

        public NotificationContext()
        {
            _notifications = new List<Notification>();
        }

        //public void AddNotification(string message)
        //{
        //    var localizeMessage = _localizer[message];
        //    var notification = new Notification(localizeMessage);
        //    _notifications.Add(notification);
        //}

        //public void AddNotification(string message, string supportLink)
        //{
        //    var localizeMessage = _localizer[message];
        //    var notification = new Notification(localizeMessage, supportLink);
        //    _notifications.Add(notification);
        //}

        public void AddNotification(string message)
        {
            var notification = new Notification(message);
            _notifications.Add(notification);
        }

        public void AddNotification(string message, string supportLink)
        {
            var notification = new Notification(message, supportLink);
            _notifications.Add(notification);
        }
    }
}
