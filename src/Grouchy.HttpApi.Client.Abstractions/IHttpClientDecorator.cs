using Grouchy.HttpApi.Client.Abstractions.Configuration;

namespace Grouchy.HttpApi.Client.Abstractions
{
    public interface IHttpClientDecorator
    {
        IHttpClient Decorate(
            IHttpClient httpClient,
            IHttpApiConfiguration httpApiConfiguration);
    }
}