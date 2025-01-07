using LiamMotorApp.Common.Services;
using LiamMotorApp.Common.Services.Interfaces;
using LiamMotorApp.Dashboard;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;

var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");

builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });

builder.Services.AddHttpClient<IApiIntegrationService, ApiIntegrationService>();

await builder.Build().RunAsync();
