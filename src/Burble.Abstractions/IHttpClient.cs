namespace Burble.Abstractions
{
   using System.Net.Http;
   using System.Threading.Tasks;

   public interface IHttpClient
   {
      Task<HttpResponseMessage> SendAsync(HttpRequestMessage request);
   }
}
