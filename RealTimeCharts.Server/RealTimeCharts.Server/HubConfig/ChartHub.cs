using Microsoft.AspNetCore.SignalR;
using RealTimeCharts.Server.Models;

namespace RealTimeCharts.Server.HubConfig
{
    public class ChartHub : Hub
    {
        public async Task BroadcastChartData(List<ChartModel> data, string connectionId)
        {
            //send or broadcast message to specific user 
            await Clients.Client(connectionId).SendAsync("broadcastchartdata", data);
            
            //send or broadcast message to all clients and users
            //await Clients.All.SendAsync("broadcastchartdata", data);
        }

        public string GetConnectionId() => Context.ConnectionId;
    }
}
