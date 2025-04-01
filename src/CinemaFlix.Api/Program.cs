using System.Text.Json;
using CinemaFlix.Infrastructure;
using NodaTime;
using NodaTime.Serialization.SystemTextJson;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddInfrastructure(builder.Configuration);

builder.Services.AddCors();
builder.Services.AddAuthorization();

builder.Services.ConfigureHttpJsonOptions(options =>
{
    options.SerializerOptions.ConfigureForNodaTime(DateTimeZoneProviders.Tzdb);
    options.SerializerOptions.PropertyNamingPolicy = JsonNamingPolicy.SnakeCaseLower;
});

builder.Services.AddHttpClient();
builder.Services.AddResponseCompression();

builder.Services.AddProblemDetails();

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseCors(b => b.AllowAnyHeader().AllowAnyMethod().AllowAnyOrigin());
}

//TODO:Add swagger

app.UseResponseCompression();

app.UseRequestLocalization(options =>
{
    options.AddSupportedCultures("pt-BR");
    options.AddSupportedUICultures("pt-BR");
    options.SetDefaultCulture("pt-BR");
});

app.UseRouting();

app.UseAuthentication();
app.UseAuthorization();

if (app.Environment.IsDevelopment())
{
}

await app.RunAsync();