using Microsoft.AspNetCore.SignalR;

namespace Signal_R_test.Hubs
{
    public class MsgHub: Hub
    {
        public Task SendMessage(string user, string message)
        {
            return Clients.All.SendAsync("ReceiveMessage", user, message);
        }
    }
}
