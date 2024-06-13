using NorthWind.BlazingPizza.Backend.BusinessObject.Option;
using NorthWind.BlazingPizza.EFCore.DataSources.Options;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddBlazingPizzaServices(
    dbOption =>
        builder.Configuration.GetRequiredSection(DBOptions.SectionKey)
            .Bind(dbOption),
    blazinPizzaOption =>
        builder.Configuration.GetRequiredSection(BlazzingPizzaOption.SectionKey)
            .Bind(blazinPizzaOption)
);

builder.Services.AddCors(options =>
{
    options.AddDefaultPolicy(builder =>
    {
        builder.AllowAnyOrigin()
            .AllowAnyHeader()
            .AllowAnyMethod();
    });
});

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseBlazingPizzaEndpoints();
app.UseCors();


app.Run();
