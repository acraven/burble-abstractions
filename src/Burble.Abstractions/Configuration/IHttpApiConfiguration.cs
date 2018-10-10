using System;

namespace Burble.Abstractions.Configuration
{
    public interface IHttpApiConfiguration
    {
        Uri Uri { get; }

        int TimeoutMs { get; }
    }
}