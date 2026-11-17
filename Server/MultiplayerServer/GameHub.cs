using Microsoft.AspNetCore.SignalR;

namespace MultiplayerServer
{
    public class GameHub : Hub
    {
        public async Task SendMessage(string message)
        {
            await Clients.All.SendAsync("ReceiveMessage", message);
        }

    }
}