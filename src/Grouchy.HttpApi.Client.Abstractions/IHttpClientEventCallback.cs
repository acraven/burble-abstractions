namespace Grouchy.HttpApi.Client.Abstractions
{
   public interface IHttpClientEventCallback
   {
      void Invoke(IHttpClientEvent @event);
   }
}
