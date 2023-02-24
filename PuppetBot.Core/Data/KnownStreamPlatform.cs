using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PuppetBot.Data;

public partial struct StreamPlatform
{
    [PredefinedData]
    public static StreamPlatform Youtube => new()
    {
        Name = "youtube",
        ChannelURLFormat = "https://youtube.com/@{0}"
    };

    [PredefinedData]
    public static StreamPlatform Twitch => new()
    {
        Name = "twitch",
        ChannelURLFormat = "https://twitch.tv/{0}"
    };

}

