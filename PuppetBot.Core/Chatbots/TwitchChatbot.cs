using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TwitchLib.Client;
using TwitchLib.Client.Events;
using TwitchLib.Client.Models;
using TwitchLib.Communication.Clients;
using TwitchLib.Communication.Models;

namespace PuppetBot.Chatbots;

public class TwitchChatbot : ChatbotBase
{
    private TwitchClient twitch;

    


    public TwitchChatbot()
    {
        twitch = new(new WebSocketClient(new ClientOptions()
        {
            MessagesAllowedInPeriod = 600,
            ThrottlingPeriod = TimeSpan.FromSeconds(5)
        })) ;

        twitch.OnJoinedChannel += OnJoinedChannel;

        
    }

    public void SignInAsStreamerAccount()
    {
        
    }

    public void SignIn(ConnectionCredentials credentials)
    {
        
    }

    #region 

    private void OnJoinedChannel(object? sender, OnJoinedChannelArgs e)
    {

    }

    #endregion

}
