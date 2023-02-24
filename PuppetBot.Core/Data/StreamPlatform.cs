using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PuppetBot.Data;

public  partial struct StreamPlatform
{
    private string channel_url_fmt = "";

    public string Name { get; init; }
    public string ChannelURLFormat
    {
        get => channel_url_fmt;
        init
        {
            if (value.Contains("{0}") && Uri.IsWellFormedUriString(string.Format(value, "PuppetBot"), UriKind.Absolute))
                channel_url_fmt = value;
            else
            {
                ArgumentException e = new("Invalid Channel URL Format string. It must well-formed URL string contains channel ID parameter '{0}'.", nameof(value));
                e.Data.Add("Input", value);

                throw e;
            }
        }
    }
    public StreamPlatform(string name, string channelURLFormat)
    {
        Name = name;
        ChannelURLFormat = channelURLFormat;
    }

    public override bool Equals([NotNullWhen(true)] object? obj)
    {
        return base.Equals(obj);
    }

    public override int GetHashCode()
    {
        return base.GetHashCode();
    }

    public override string ToString()
    {
        return Name.Capitalize();
    }
}
