

using PuppetBot.Server.Hubs;

namespace PuppetBot.Server.Utilities
{
    public static class WebHostExtensions
    {
        public static IWebHostBuilder ListenFromPort(this ConfigureWebHostBuilder builder, int port)
        {
            return builder.UseUrls(new UriBuilder("http://localhost")
            {
                Port = port
            }.Uri.ToString());
        }

        public static void MapSignalRHubs(this WebApplication app)
        {
            app.MapHub<ChattingHub>("/chat");
        }
    }
}
