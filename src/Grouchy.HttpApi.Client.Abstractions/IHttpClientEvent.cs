using System;
using System.Collections.Generic;
using System.Net.Http;

namespace Grouchy.HttpApi.Client.Abstractions
{
   // TODO: Should this inherit IEvent?
   public interface IHttpClientEvent
   {
      string EventType { get; }

      DateTimeOffset Timestamp { get; }

      IDictionary<string, object> Tags { get; }

      string Uri { get; }

      string Method { get; }

      HttpRequestMessage Request { get; }
   }
}