using PersonMinimalApi.Models;

namespace PersonMinimalApi.Routes;

public static class PersonRoute
{
    public static void MapPersonRoutes(this WebApplication app)
    {
        app.MapGet("/person", () => new PersonModel("Test", "123123123", "masc", "test@gmail.com"));
    }
}