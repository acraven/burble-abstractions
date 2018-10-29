using System;

namespace Burble.Abstractions.Configuration
{
    public interface IHttpApiConfiguration
    {
        string Name { get; }
        
        Uri Uri { get; }

        int? TimeoutMs { get; }
    }
}