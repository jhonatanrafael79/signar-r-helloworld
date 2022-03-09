using Microsoft.AspNetCore.SignalR;
using System.Threading.Tasks;

namespace SignalR.Client.Hubs
{
    public class ChatHub : Hub
    {
        public async Task SendMessage(string user, string message)
        {
            //Enviar mensaje a todos clientes que están conectados
            await Clients.All.SendAsync("ReceiveMessage", user, message);
        }
    }
}
