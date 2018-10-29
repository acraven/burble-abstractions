using System.Collections.Generic;

namespace Burble.Abstractions.CircuitBreaking
{
   public class Metrics<TResponse>
   {
      public IDictionary<TResponse, int> SuccessResponses { get; } = new Dictionary<TResponse, int>();

      public IDictionary<TResponse, int> FailureResponses { get; } = new Dictionary<TResponse, int>();

      public int Timeouts { get; set; }

      public int Exceptions { get; set; }
         
      public int Rejections { get; set; }
   }
}