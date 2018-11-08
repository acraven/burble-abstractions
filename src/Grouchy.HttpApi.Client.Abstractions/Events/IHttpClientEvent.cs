using Grouchy.Abstractions.Events;

namespace Grouchy.HttpApi.Client.Abstractions.Events
{
   public interface IHttpClientEvent : IEvent
   {
      string Uri { get; }

      string Method { get; }
   }
}