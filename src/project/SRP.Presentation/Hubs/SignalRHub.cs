﻿using MediatR;
using Microsoft.AspNetCore.SignalR;
using SRP.Application.Features.Bookings.Queries.GetAll;
using SRP.Application.Features.Categories.Queries.GetActiveCount;
using SRP.Application.Features.Categories.Queries.GetCount;
using SRP.Application.Features.Categories.Queries.GetPassiveCount;
using SRP.Application.Features.MenuTables.Queries.GetAll;
using SRP.Application.Features.MenuTables.Queries.GetCount;
using SRP.Application.Features.MoneyCases.Queries.GetTotalPrice;
using SRP.Application.Features.Notifications.Queries.GetAllByStatus;
using SRP.Application.Features.Notifications.Queries.GetAllCountByStatus;
using SRP.Application.Features.Orders.Queries.GetActiveCount;
using SRP.Application.Features.Orders.Queries.GetCount;
using SRP.Application.Features.Orders.Queries.GetLastPrice;
using SRP.Application.Features.Orders.Queries.GetTodayTotalPrice;
using SRP.Application.Features.Products.Queries.GetCount;
using SRP.Application.Features.Products.Queries.GetCountWithCategoryName;
using SRP.Application.Features.Products.Queries.GetNameByMaxPrice;
using SRP.Application.Features.Products.Queries.GetNameByMinPrice;
using SRP.Application.Features.Products.Queries.GetTotalAverageCategoryName;
using SRP.Application.Features.Products.Queries.GetTotalAveragePrice;

namespace SRP.Presentation.Hubs;

public class SignalRHub(IMediator mediator) : Hub
{
    public static int ClientCount { get; set; }

    public async Task SendStatistics()
    {
        await Clients.All.SendAsync("ReceiveStatistics", new Dictionary<string, object>
        {
            ["categoryCount"] = await mediator.Send(new CategoryGetCountQuery()),
            ["categoryActiveCount"] = await mediator.Send(new CategoryGetActiveCountQuery()),
            ["categoryPassiveCount"] = await mediator.Send(new CategoryGetPassiveCountQuery()),
            ["productCount"] = await mediator.Send(new ProductGetCountQuery()),
            ["productGetTotalAveragePriceWithCategoryHamburger"] =
                await mediator.Send(new ProductGetCountWithCategoryName { CategoryName = "Burger" }),
            ["productGetTotalAveragePriceWithCategoryDrink"] = await mediator.Send(new ProductGetCountWithCategoryName
                { CategoryName = "Drink" }),
            ["productGetTotalAveragePriceQuery"] =
                $"{await mediator.Send(new ProductGetTotalAveragePriceQuery()):0.00} ₺",
            ["productGetNameByMaxPriceQuery"] = await mediator.Send(new ProductGetNameByMaxPriceQuery()),
            ["productGetNameByMinPriceQuery"] = await mediator.Send(new ProductGetNameByMinPriceQuery()),
            ["productGetTotalAverageCategoryNameQueryHamburger"] =
                $"{await mediator.Send(new ProductGetTotalAverageCategoryNameQuery { CategoryName = "Burger" }):0.00} ₺",
            ["orderGetCountQuery"] = await mediator.Send(new OrderGetCountQuery()),
            ["orderGetActiveCountQuery"] = await mediator.Send(new OrderGetActiveCountQuery()),
            ["orderGetLastPriceQuery"] = $"{await mediator.Send(new OrderGetLastPriceQuery()):0.00} ₺",
            ["orderGetTodayTotalPriceQuery"] = $"{await mediator.Send(new OrderGetTodayTotalPriceQuery()):0.00} ₺",
            ["moneyCaseGetTotalPriceQuery"] = $"{await mediator.Send(new MoneyCaseGetTotalPriceQuery()):0.00} ₺",
            ["menuTableGetCountQuery"] = await mediator.Send(new MenuTableGetCountQuery())
        });
    }


    public async Task SendProgress()
    {
        await Clients.All.SendAsync("ReceiveProgress", new Dictionary<string, object>
        {
            ["moneyCaseGetTotalPriceQuery"] = $"{await mediator.Send(new MoneyCaseGetTotalPriceQuery()):0.00} ₺",
            ["orderGetActiveCountQuery"] = await mediator.Send(new OrderGetActiveCountQuery()),
            ["menuTableGetCountQuery"] = await mediator.Send(new MenuTableGetCountQuery()),
        });
    }

    public async Task GetBookingList()
    {
        await Clients.All.SendAsync("ReceiveBookingList", await mediator.Send(new BookingGetAllQuery()));
    }

    public async Task SendNotifications()
    {
        await Clients.All.SendAsync("ReceiveNotifications", new Dictionary<string, object>
        {
            ["notificationGetAllCountByStatusFalseQuery"] = await mediator.Send(new NotificationGetAllCountByStatusQuery
                { Status = false }),
            ["notificationGetAllByStatusFalseQuery"] =
                await mediator.Send(new NotificationGetAllByStatusQuery { Status = false }),
        });
    }

    public async Task GetMenuTableStatus()
    {
        await Clients.All.SendAsync("ReceiveMenuTableStatus", await mediator.Send(new MenuTableGetAllQuery()));
    }

    public async Task SendMessage(string user, string message)
    {
        await Clients.All.SendAsync("ReceiveMessage", user, message);
    }


    public override async Task OnConnectedAsync()
    {
        ClientCount++;
        await Clients.All.SendAsync("ReceiveClientCount", ClientCount);
        await base.OnConnectedAsync();
    }

    public override async Task OnDisconnectedAsync(Exception? exception)
    {
        ClientCount--;
        await Clients.All.SendAsync("ReceiveClientCount", ClientCount);
        await base.OnDisconnectedAsync(exception);
    }
}