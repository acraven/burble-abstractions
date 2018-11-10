using Grouchy.Abstractions.Events;

namespace Grouchy.HttpApi.Client.Abstractions.Events
{
   public interface IHttpClientEvent : IEvent
   {
      string Method { get; }

      string TargetService { get; }

      string Uri { get; }
   }
}