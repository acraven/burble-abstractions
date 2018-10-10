using System;
using System.Collections.Generic;

namespace Burble.Abstractions
{
    public interface IEvent
    {
        string EventType { get; }

        DateTimeOffset Timestamp { get; }

        IDictionary<string, object> Tags { get; }
    }
}