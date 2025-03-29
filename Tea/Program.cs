using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Web;

using Tea.Data;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorPages();
builder.Services.AddServerSideBlazor();
builder.Services.AddSingleton<WeatherForecastService>();
// ������ ����� ��� ����������
builder.Services.AddRazorPages();
builder.Services.AddControllers(); // ������ ���������� ��� API


var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseStaticFiles(); // ������ �� wwwroot
app.MapControllers(); // ������ �������� ��� ����������
app.MapRazorPages();
app.UseHttpsRedirection();

app.UseStaticFiles();

app.UseRouting();

app.MapBlazorHub();
app.MapFallbackToPage("/_Host");



app.Run();
