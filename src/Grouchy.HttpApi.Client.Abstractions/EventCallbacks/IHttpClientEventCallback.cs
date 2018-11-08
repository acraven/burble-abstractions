using Grouchy.HttpApi.Client.Abstractions.Events;

namespace Grouchy.HttpApi.Client.Abstractions.EventCallbacks
{
   public interface IHttpClientEventCallback
   {
      void Invoke(IHttpClientEvent @event);
   }
}
