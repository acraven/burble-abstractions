using System.Collections.Generic;

namespace Burble.Abstractions.CircuitBreaking
{
   public interface ICircuitBreakerAnalyser<TResponse>
   {
      CircuitBreakerAnalysis Analyse(IEnumerable<Metrics<TResponse>> recentMetrics);
   }
}