using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace PuppetBot.Data;


public sealed class PuppetHello
{
    public Version ClientVersion { get; set; } = Assembly.GetEntryAssembly()?.GetName().Version ?? new(1, 0);
    
}
