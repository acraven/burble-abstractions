using System.Net.Http;

namespace Burble.Abstractions
{
   public interface IHttpClientEvent : IEvent
   {
      string Uri { get; }

      string Method { get; }

      HttpRequestMessage Request { get; }
   }
}