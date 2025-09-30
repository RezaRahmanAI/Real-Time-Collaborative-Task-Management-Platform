using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.SignalR;

namespace API.RealTime;

[Authorize]
public class NotificationHub : Hub
{
    // We'll add presence & events later.
    public async Task Ping() => await Clients.Caller.SendAsync("Pong", DateTime.UtcNow);
}
