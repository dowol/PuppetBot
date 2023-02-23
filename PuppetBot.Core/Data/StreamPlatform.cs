using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PuppetBot.Data;

public sealed partial class StreamPlatform
{
    public string ID { get; }
    public string Name { get; }

    internal StreamPlatform(string identify, string name, Uri url)
    {

    }
}
