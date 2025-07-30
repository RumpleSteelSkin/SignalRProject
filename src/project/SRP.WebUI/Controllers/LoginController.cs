using Core.CrossCuttingConcerns.Exceptions.ExceptionTypes;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using SRP.WebUI.Constants;
using SRP.WebUI.Dtos.Identity;

namespace SRP.WebUI.Controllers;
[AllowAnonymous]
public class LoginController(IHttpClientFactory httpClientFactory, IHttpContextAccessor httpContextAccessor)
    : Controller
{
    
    [HttpGet]
    public IActionResult Index()
    {
        return View();
    }

    [HttpPost]
    public async Task<IActionResult> Index(LoginDto loginDto)
    {
        var client = httpClientFactory.CreateClient();
        var response = await client.PostAsJsonAsync(ApiRoutes.Auth.Login, loginDto);
        if (!response.IsSuccessStatusCode)
        {
            throw new AuthorizationException("Login failed");
        }

        var result = await response.Content.ReadFromJsonAsync<LoginResponseDto>();
        var token = result?.Token;

        httpContextAccessor.HttpContext?.Response.Cookies.Append("access_token", token!, new CookieOptions
        {
            HttpOnly = true,
            Secure = true,
            SameSite = SameSiteMode.Strict,
            Expires = DateTimeOffset.UtcNow.AddHours(1)
        });


        return RedirectToAction("Index","Default");
    }
}