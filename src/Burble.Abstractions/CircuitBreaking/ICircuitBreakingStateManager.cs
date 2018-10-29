using System.Threading;
using System.Threading.Tasks;
using Burble.Abstractions.Configuration;

namespace Burble.Abstractions.CircuitBreaking
{
   public interface ICircuitBreakingStateManager<TResponse>
   {
      ICircuitBreakingState<TResponse> Get(ICircuitBreakingConfiguration<TResponse> configuration);
      
      Task StopMonitoringAsync(CancellationToken cancellationToken);
   }
}