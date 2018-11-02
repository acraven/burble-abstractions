using Grouchy.HttpApi.Client.Abstractions.Configuration;

namespace Grouchy.HttpApi.Client.Abstractions
{
    public interface IHttpClientRegistry
    {
        IHttpClient Get<TConfiguration>(TConfiguration configuration) where TConfiguration : IHttpApiConfiguration;
    }
}