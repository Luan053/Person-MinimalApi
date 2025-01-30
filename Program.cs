var builder = WebApplication.CreateBuilder(args);
builder.AddArchitectures().AddServices();

var app = builder.Build();

app.MapRoutes();

app.UseArchitectures();
app.Run();