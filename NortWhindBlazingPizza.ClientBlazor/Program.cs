using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using NorthWind.BlazingPizza.Frontend.BusinessObjects.Option;
using NorthWind.BlazingPizza.Frontend.IoC;
using NorthWind.BlazingPizza.Frontend.RazorViews.Routing;
using NortWhindBlazingPizza.ClientBlazor;

var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");

builder.Configuration.AddJsonFile("appsettings.json", optional: false, reloadOnChange: true);

builder.Services.AddBlazingPizzaServices(
    blazingPizzaOptions =>
        builder.Configuration.GetRequiredSection(BlazingPizzaOptions.SectionKey)
            .Bind(blazingPizzaOptions));


await builder.Build().RunAsync();
