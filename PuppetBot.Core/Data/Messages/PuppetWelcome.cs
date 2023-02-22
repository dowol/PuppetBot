using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace PuppetBot.Data.Messages;

public sealed class PuppetWelcome
{
    public PuppetAccessStatus AccessStatus { get; set; } = PuppetAccessStatus.Rejected;
    public Version ServerVersion { get; set; } = Assembly.GetEntryAssembly()?.GetName().Version ?? new(1, 0);

    public string[]? PuppetProfiles { get; set; }
    public string? CurrentProfile { get; set; }




}

public enum PuppetAccessStatus
{
    Accepted,
    Rejected,
    Unavailable
}