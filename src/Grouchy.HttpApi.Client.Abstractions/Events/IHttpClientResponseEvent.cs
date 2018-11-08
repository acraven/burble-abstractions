namespace Grouchy.HttpApi.Client.Abstractions.Events
{
   public interface IHttpClientResponseEvent : IHttpClientEvent
   {
      int StatusCode { get; }
      
      long DurationMs { get; }
   }
}