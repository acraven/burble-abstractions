namespace Burble.Abstractions
{
   using System.Net.Http;

   public interface IHttpClientEventCallback
   {
      void Invoke(IHttpClientEvent @event, HttpRequestMessage request);
   }
}
