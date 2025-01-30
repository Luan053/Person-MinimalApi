namespace PersonMinimalApi.Models;

public class PersonModel
 {
     public PersonModel( string name, string cpf, string gender, string? email = null )
     {
         Id = Guid.NewGuid();
         Name = name;
         Cpf = cpf;
         Gender = gender;
         Email = email;
     }
     public Guid Id { get; init; }
     public string Name { get; private set; }
     public string Cpf { get; private set; }
     public string Gender { get; private set; }
     public string? Email { get; private set; }
 }