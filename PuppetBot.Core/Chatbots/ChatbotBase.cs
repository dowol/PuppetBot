using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PuppetBot.Chatbots;

public abstract class ChatbotBase
{
    


    
    
    protected virtual void Chatbot_OnConnected()
    {

    }

    protected virtual void Chatbot_OnDisconnected()
    {

    }
}


public delegate void ChatReceivedEventHandler(object? sender);