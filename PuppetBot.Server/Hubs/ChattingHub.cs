using Microsoft.AspNetCore.SignalR;
using PuppetBot.Data.Chatbots;

namespace PuppetBot.Server.Hubs;

public class ChattingHub : Hub
{

    public async void SendChat(ChattingData chat)
    {


    }

    public async void ReceiveChat(ChattingData chat)
    {
        await Clients.All.SendAsync("Chat", chat);
    }



    public override async Task OnConnectedAsync()
    {
        
        await Task.CompletedTask;
    }

    public override async Task OnDisconnectedAsync(Exception? exception)
    {
        if (exception is not null)
        {

        }
        else
        {

        }

        await Task.CompletedTask;
    }
}
