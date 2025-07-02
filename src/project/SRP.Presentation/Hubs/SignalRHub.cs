using Microsoft.AspNetCore.SignalR;
using SRP.Persistence.Contexts;

namespace SRP.Presentation.Hubs;

public class SignalRHub(BaseDbContext context) : Hub
{
    public async Task SendCategoryCount()
    {
        await Clients.All.SendAsync("ReceiveCategoryCount", context.Categories.Count());
    }
}