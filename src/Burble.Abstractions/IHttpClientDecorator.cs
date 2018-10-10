namespace Burble.Abstractions
{
    public interface IHttpClientDecorator
    {
        IHttpClient Decorate(IHttpClient httpClient);
    }
}