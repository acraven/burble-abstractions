using Burble.Abstractions.CircuitBreaking;

namespace Burble.Abstractions.Configuration
{
   public interface ICircuitBreakingConfiguration<TResponse>
   {
      int? MonitoringPeriodMs { get; }

      int[] ProgressiveOpeningRates { get; }

      // TODO: This smells. Maybe have some sort of registry and extension method for changing this
      ICircuitBreakerAnalyser<TResponse> Analyser {get;}
   }
}