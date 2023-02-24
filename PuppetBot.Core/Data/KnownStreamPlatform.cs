using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PuppetBot.Data;

public sealed partial class StreamPlatform
{
    [PredefinedData]
    public static StreamPlatform Youtube => new()
    {
        Name = "youtube",
        URL = new("https://youtube.com")
    };

    [PredefinedData]
    public static StreamPlatform Twitch => new()
    {
        Name = "twitch",
        URL = new("https://twitch.tv")
    };
}

