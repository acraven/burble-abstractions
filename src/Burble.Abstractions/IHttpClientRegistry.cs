using Burble.Abstractions.Configuration;

namespace Burble.Abstractions
{
    public interface IHttpClientRegistry
    {
        IHttpClient Get<TConfiguration>(TConfiguration configuration) where TConfiguration : IHttpApiConfiguration;
    }
}