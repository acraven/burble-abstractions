using System;

namespace Grouchy.HttpApi.Client.Abstractions.Configuration
{
    public interface IHttpApiConfiguration
    {
        string Name { get; }
        
        Uri Uri { get; }

        int? TimeoutMs { get; }
    }
}