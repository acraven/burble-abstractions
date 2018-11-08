using Grouchy.HttpApi.Client.Abstractions.Configuration;
using Grouchy.HttpApi.Client.Abstractions.HttpClients;

namespace Grouchy.HttpApi.Client.Abstractions
{
    public interface IHttpClientRegistry
    {
        IHttpClient Get<TConfiguration>(TConfiguration configuration) where TConfiguration : IHttpApiConfiguration;
    }
}