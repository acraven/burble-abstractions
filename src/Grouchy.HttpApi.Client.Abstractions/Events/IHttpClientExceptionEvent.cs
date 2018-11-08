using System;

namespace Grouchy.HttpApi.Client.Abstractions.Events
{
   public interface IHttpClientExceptionEvent : IHttpClientEvent
   {
      Exception Exception { get; }
      
      long DurationMs { get; }
   }
}