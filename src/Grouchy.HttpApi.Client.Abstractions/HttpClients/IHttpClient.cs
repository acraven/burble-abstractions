using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;

namespace Grouchy.HttpApi.Client.Abstractions.HttpClients
{
   public interface IHttpClient
   {
      Task<HttpResponseMessage> SendAsync(HttpRequestMessage request, CancellationToken cancellationToken);
   }
}
