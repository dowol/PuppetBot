using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PuppetBot.Data;

public sealed partial class StreamPlatform
{
    [PredefinedData]
    public static StreamPlatform Youtube { get; }

    [PredefinedData]
    public static StreamPlatform Twitch { get; }
}

