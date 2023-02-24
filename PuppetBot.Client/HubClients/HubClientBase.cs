using Microsoft.AspNetCore.SignalR.Client;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PuppetBot.Client.HubClients;

public abstract class HubClientBase
{
    public HubConnection Client { get; protected init; }

    protected HubClientBase()
    {
        
    }

}
