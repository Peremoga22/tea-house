using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Web;

using Tea.Data;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorPages();
builder.Services.AddServerSideBlazor();
builder.Services.AddSingleton<WeatherForecastService>();
// Додаємо сервіс для контролерів
builder.Services.AddRazorPages();
builder.Services.AddControllers(); // Додаємо контролери для API


var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseStaticFiles(); // Доступ до wwwroot
app.MapControllers(); // Додаємо маршрути для контролерів
app.MapRazorPages();
app.UseHttpsRedirection();

app.UseStaticFiles();

app.UseRouting();

app.MapBlazorHub();
app.MapFallbackToPage("/_Host");



app.Run();
