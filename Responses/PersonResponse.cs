namespace PersonMinimalApi.Responses;

public record PersonResponse(Guid Id, string Name, string Cpf, string Gender, string? Email);