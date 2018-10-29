using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;

namespace Burble.Abstractions
{
   public interface IHttpClient
   {
      Task<HttpResponseMessage> SendAsync(HttpRequestMessage request, CancellationToken cancellationToken);
   }
}
