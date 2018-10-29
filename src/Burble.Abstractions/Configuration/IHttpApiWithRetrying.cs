using Burble.Abstractions.Retrying;

namespace Burble.Abstractions.Configuration
{
   public interface IHttpApiWithRetrying : IHttpApiConfiguration
   {
      IRetryPredicate RetryPredicate { get; }

      IRetryDelay RetryDelay { get; }
   }
}