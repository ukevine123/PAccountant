using Web.Components;
using MudBlazor.Services;
using Application.Service.Liabilities;



var builder = WebApplication.CreateBuilder(args);

builder.Services.AddMudServices();//mudblazor services for UI components

// Add services to the container.
builder.Services.AddRazorComponents()
    .AddInteractiveServerComponents();

    // Dependency Injection for application services

        builder.Services.AddScoped<ILiabilityService, LiabilityService>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error", createScopeForErrors: true);
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}
app.UseStatusCodePagesWithReExecute("/not-found", createScopeForStatusCodePages: true);
app.UseHttpsRedirection();

app.UseAntiforgery();

app.MapStaticAssets();
app.MapRazorComponents<App>()
    .AddInteractiveServerRenderMode();

app.Run();