namespace Grouchy.HttpApi.Client.Abstractions.Configuration
{
   public interface IHttpApiWithCircuitBreaking : IHttpApiConfiguration
   {
      string CircuitBreakerPolicy { get; }
   }
}