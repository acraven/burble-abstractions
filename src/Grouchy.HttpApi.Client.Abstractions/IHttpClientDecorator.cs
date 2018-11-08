using Grouchy.HttpApi.Client.Abstractions.Configuration;
using Grouchy.HttpApi.Client.Abstractions.HttpClients;

namespace Grouchy.HttpApi.Client.Abstractions
{
    public interface IHttpClientDecorator
    {
        IHttpClient Decorate(
            IHttpClient httpClient,
            IHttpApiConfiguration httpApiConfiguration);
    }
}