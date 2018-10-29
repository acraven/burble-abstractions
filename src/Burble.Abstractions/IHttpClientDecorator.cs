using Burble.Abstractions.Configuration;

namespace Burble.Abstractions
{
    public interface IHttpClientDecorator
    {
        IHttpClient Decorate(
            IHttpClient httpClient,
            IHttpApiConfiguration httpApiConfiguration);
    }
}