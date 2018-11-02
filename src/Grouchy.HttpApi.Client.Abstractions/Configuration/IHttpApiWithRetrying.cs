namespace Grouchy.HttpApi.Client.Abstractions.Configuration
{
   public interface IHttpApiWithRetrying : IHttpApiConfiguration
   {
      string RetryPolicy { get; }
   }
}