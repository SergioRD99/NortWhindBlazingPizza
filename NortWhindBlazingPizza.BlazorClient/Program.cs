using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using NorthWind.BlazingPizza.Frontend.BusinessObjects.Option;
using NorthWind.BlazingPizza.Frontend.IoC;
using NorthWind.BlazingPizza.Frontend.RazorViews.Routing;
using NortWhindBlazingPizza.BlazorClient;

var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");

builder.Services.AddBlazingPizzaServices(
    blazinPizzaOption => 
        builder.Configuration.GetRequiredSection(BlazingPizzaOptions.SectionKey)
            .Bind(blazinPizzaOption));

await builder.Build().RunAsync();
