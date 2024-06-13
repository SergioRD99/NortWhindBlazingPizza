using NorthWind.BlazingPizza.Frontend.IoC;
var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");

builder.Services.AddBlazingPizzaServices(
    blazingPizzaOption =>
        builder.Configuration.GetRequiredSection(BlazingPizzaOptions.SectionKey)
            .Bind(blazingPizzaOption));

await builder.Build().RunAsync();
