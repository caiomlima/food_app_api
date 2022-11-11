namespace Api.Domain
{
    public class Notification
    {
        public string Message { get; }
        public string SupportLink { get; }

        public Notification(string message)
        {
            Message = message;
        }

        public Notification(string message, string supportLink)
        {
            Message = message;
            SupportLink = supportLink;
        }
    }
}
