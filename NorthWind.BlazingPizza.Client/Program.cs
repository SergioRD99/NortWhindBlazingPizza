using NorthWind.BlazingPizza.Frontend.IoC;

var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");

builder.Services.AddBlazingPizzaServices();

await builder.Build().RunAsync();
