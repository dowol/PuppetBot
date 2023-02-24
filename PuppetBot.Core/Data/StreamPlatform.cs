using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PuppetBot.Data;

public sealed partial class StreamPlatform
{
    public string Name { get; init; }
    public Uri URL { get; init; }

#pragma warning disable CS8618
    private StreamPlatform() { }
#pragma warning restore CS8618
}
