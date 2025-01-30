namespace PersonMinimalApi.Routes;

public static class ExampleRoutes
{
    public static WebApplication MapExampleRoutes(this WebApplication app)
    {
        app.MapGet("/person", () => "Hello World!");
        return app;
    }
}