using Burble.Abstractions.Throttling;

namespace Burble.Abstractions.Configuration
{
   public interface IHttpApiWithThrottling : IHttpApiConfiguration
   {
      IThrottleSync ThrottleSync { get; }
   }
}