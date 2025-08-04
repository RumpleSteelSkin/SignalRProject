using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using SRP.WebUI.Constants;
using SRP.WebUI.Dtos.MenuTables;
using SRP.WebUI.Hooks.Jsons;

namespace SRP.WebUI.Controllers
{
    [AllowAnonymous]
    public class CustomerTableController(JsonService jsonService) : Controller
    {
        public async Task<ActionResult> CustomerTableList()
        {
            return View(await jsonService.GetAllAsync<ResultMenuTableDto>(ApiRoutes.MenuTable.GetAll));
        }

    }
}
