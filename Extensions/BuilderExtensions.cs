using PersonMinimalApi.Data;

namespace PersonMinimalApi.Extensions;

public static class BuilderExtensions
{
    public static WebApplicationBuilder AddArchitectures(this WebApplicationBuilder builder)
    {
        builder.Services.AddSingleton<PersonContext>();
        return builder;
    }
    public static WebApplicationBuilder AddServices(this WebApplicationBuilder builder)
    {
        builder.Services.AddEndpointsApiExplorer();
        builder.Services.AddSwaggerGen();
        return builder;
    }
}