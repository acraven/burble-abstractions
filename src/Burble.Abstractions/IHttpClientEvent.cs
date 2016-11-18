namespace Burble.Abstractions
{
   using System;
   using System.Collections.Generic;
   using System.Net.Http;

   public interface IHttpClientEvent
   {
      string EventType { get; }

      DateTimeOffset Timestamp { get; }

      string Uri { get; }

      string Method { get; }

      IDictionary<string, object> Tags { get; }

      HttpRequestMessage Request { get; }
   }
}