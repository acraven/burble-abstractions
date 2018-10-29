using System.Net;

namespace Burble.Abstractions.Configuration
{
   public interface IHttpApiWithCircuitBreaking : IHttpApiConfiguration, ICircuitBreakingConfiguration<HttpStatusCode>
   {
   }
}