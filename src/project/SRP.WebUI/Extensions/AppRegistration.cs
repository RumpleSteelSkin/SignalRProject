namespace SRP.WebUI.Extensions;

public static class AppRegistration
{
    public static WebApplication AddWebUiApp(this WebApplication app)
    {
        #region Exception Handling
        if (!app.Environment.IsDevelopment())
        {
            app.UseExceptionHandler("/Home/Error");
            app.UseHsts();
        }
        #endregion

        #region Middleware Pipeline
        app.UseHttpsRedirection();
        app.UseStaticFiles();
        app.UseRouting();
        app.UseAuthentication();
        app.UseAuthorization();
        #endregion

        #region Endpoints
        app.UseStatusCodePages(x =>
        {
            if (x.HttpContext.Response.StatusCode == 404)
            {
                x.HttpContext.Response.Redirect($"/Error/NotFound404Page/");
            }
            return Task.CompletedTask;
        });
        
        app.MapControllerRoute(
            name: "default",
            pattern: "{controller=Product}/{action=Index}/{id?}");
        #endregion

        app.Run();
        return app;
    }
}