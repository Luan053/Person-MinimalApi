namespace PersonMinimalApi.Routes;

public static class RoutesExtensions
{
    public static void MapRoutes(this WebApplication app)
    {
        app.MapExampleRoutes();
            
    }
}