namespace Grouchy.HttpApi.Client.Abstractions.Events
{
   public interface IHttpClientRetryEvent : IHttpClientEvent
   {
      int Attempt { get; }
   }
}