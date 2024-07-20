using Microsoft.AspNetCore.Hosting.Builder;
using NLog.Web;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllersWithViews();
// connect logging in project
builder.Logging.ClearProviders();
builder.WebHost.UseNLog();

var app = builder.Build();

if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=TypingMain}/{action=Type}/{id?}");

app.Run();
