using System.Net.Http;

namespace Burble.Abstractions.Retrying
{
   public interface IRetryPredicate
   {
      bool ShouldRetry(int retryAttempt, HttpResponseMessage response);
   }
}
