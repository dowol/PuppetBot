using Microsoft.AspNetCore.SignalR;
using PuppetBot.Data;
using System.Security.Cryptography.X509Certificates;

namespace PuppetBot.Server.Hubs;

public class PuppetGreetingsHub : Hub
{
    public PuppetGreetingsHub()
    {
        
    }

    public async Task SendWelcome(string connectionID, PuppetWelcome welcomeMessage)
    {
        await Clients.Client(connectionID).SendAsync("Welcome", welcomeMessage);
    }
}
