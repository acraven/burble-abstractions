namespace Burble.Abstractions.Retrying
{
   public interface IRetryDelay
   {
      int DelayMs(int retryAttempt);
   }
}