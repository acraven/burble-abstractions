namespace Burble.Abstractions
{
   public interface IHttpClientEventCallback
   {
      void Invoke(IHttpClientEvent @event);
   }
}
