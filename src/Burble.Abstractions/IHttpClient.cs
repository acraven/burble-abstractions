using System;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;

namespace Burble.Abstractions
{
   public interface IHttpClient
   {
      Uri BaseAddress { get; }

      Task<HttpResponseMessage> SendAsync(HttpRequestMessage request, CancellationToken cancellationToken);
   }
}
