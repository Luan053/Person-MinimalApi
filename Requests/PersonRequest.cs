namespace PersonMinimalApi.Requests;

public record PersonRequest(string Name, string Cpf, string Gender, string? Email);