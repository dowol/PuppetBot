using Microsoft.AspNetCore.SignalR;
using PuppetBot.Server.Hubs;

namespace PuppetBot.Server.Services;

public class ChattingService : IHostedService
{
    private IHubContext<ChattingHub> hubContext;

    public ChattingService(IHubContext<ChattingHub> hubContext)
    {
        this.hubContext = hubContext;
    }

    public async Task StartAsync(CancellationToken cancellationToken)
    {
        await hubContext.Clients.All.SendAsync("ReceiveChat");
        

        await Task.CompletedTask;
    }

    public async Task StopAsync(CancellationToken cancellationToken)
    {
        await Task.CompletedTask;
    }
}
