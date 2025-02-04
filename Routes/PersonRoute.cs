using PersonMinimalApi.Data;
using PersonMinimalApi.Models;
using PersonMinimalApi.Requests;
using PersonMinimalApi.Responses;

namespace PersonMinimalApi.Routes;

public static class PersonRoute
{
    public static void MapPersonRoutes(this WebApplication app)
    {
        var route = app.MapGroup("person");

        route.MapPost("", async (PersonRequest req, PersonContext context) =>
        {
            var person = new PersonModel(req.Name, req.Cpf, req.Gender, req.Email);
            await context.AddAsync(person);
            await context.SaveChangesAsync();

            var response = new PersonResponse(person.Id, person.Name, person.Cpf, person.Gender, person.Email);
            return Results.Created($"/person/{person.Id}", response);
        });
    }
}