using System;
using System.Net.Http;

namespace Burble.Abstractions.CircuitBreaking
{
   public interface ICircuitBreakingState<in TResponse>
   {
      double ClosedPct { get; }

      bool ShouldAccept();

      void LogSuccessResponse(TResponse response);

      void LogFailureResponse(TResponse response);

      void LogTimeout();

      void LogException(Exception exception);

      void LogWithheld();
   }
}