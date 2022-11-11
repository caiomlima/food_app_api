using Api.Domain;
using Microsoft.AspNetCore.Mvc.Filters;
using System.Net;
using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;
using Newtonsoft.Json.Linq;
using Api.DTO.Notification;

namespace Api.Infrastructure
{
    //public class DomainNotificationFilter : IAsyncResultFilter
    //{
    //    private readonly ISerializer _serializer;
    //    private readonly INotificationContext _notificationContext;

    //    public DomainNotificationFilter(
    //        INotificationContext notificationContext,
    //        ISerializer serializer)
    //    {
    //        _serializer = serializer;
    //        _notificationContext = notificationContext;
    //    }

    //    public async Task OnResultExecutionAsync(ResultExecutingContext context, ResultExecutionDelegate next)
    //    {
    //        if (_notificationContext.HasNotifications)
    //        {
    //            context.HttpContext.Response.StatusCode = (int)HttpStatusCode.BadRequest;
    //            context.HttpContext.Response.ContentType = "application/json";

    //            var messages = string.Join(",", _notificationContext.Notifications.Select(x => x.Message));
    //            var supportLinks = string.Join(",", _notificationContext.Notifications.Select(x => x.SupportLink));

    //            var response = new ProblemDetailsDto(messages, context.HttpContext.Response.StatusCode, supportLinks);
    //            var serialized = _serializer.Serialize(response);

    //            await context.HttpContext.Response.WriteAsync(serialized);

    //            return;
    //        }

    //        await next();
    //    }

    //    public interface ISerializer
    //    {
    //        string Serialize(object value);

    //        T Deserialize<T>(string value);
    //    }

    //    public class AppSerializer : ISerializer
    //    {
    //        public T Deserialize<T>(string value)
    //        {
    //            return JsonConvert.DeserializeObject<T>(value, new NotificationConverter());
    //        }

    //        public string Serialize(object value)
    //        {
    //            return JsonConvert.SerializeObject(value, new JsonSerializerSettings
    //            {
    //                Formatting = Formatting.None,
    //                NullValueHandling = NullValueHandling.Ignore,
    //                DateFormatHandling = DateFormatHandling.IsoDateFormat,
    //                ContractResolver = new CamelCasePropertyNamesContractResolver()
    //            });
    //        }
    //    }

    //    public class NotificationConverter : JsonConverter
    //    {
    //        public override bool CanConvert(Type objectType)
    //        {
    //            return typeof(Notification).IsAssignableFrom(objectType);
    //        }

    //        public override object ReadJson(JsonReader reader,
    //            Type objectType, object existingValue, JsonSerializer serializer)
    //        {
    //            var jo = JObject.Load(reader);

    //            if (jo["notificationType"] == null && jo["NotificationType"] == null)
    //                return null;

    //            var propertyName = "notificationType";
    //            if (jo[propertyName] == null)
    //                propertyName = "NotificationType";

    //            var notificationType = Convert.ToInt32(jo[propertyName]);
    //            Notification item = null;

    //            //else if (notificationType == (int)NotificationTypes.Navigation)
    //            //    item = new NavigationNotification();

    //            serializer.Populate(jo.CreateReader(), item);

    //            return item;
    //        }

    //        public override bool CanWrite
    //        {
    //            get { return false; }
    //        }

    //        public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
    //        {
    //            throw new NotImplementedException();
    //        }
    //    }
    //}
}
